using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace UtilitarioSuporte.Negocio
{
    public static class Funcoes
    {
        public static List<string> DescriptografarStringConexao()
        {
            List<string> descriptografar = new List<string>();
            string conexao = DescriptografarConexaoBanco().ToString();
            //Separação da StringConexão e do IdEmpresa que está criptografado no arquivo Configuração.
            string[] infoConf = conexao.Split('|');
            descriptografar.Add(infoConf[0]);
            descriptografar.Add(infoConf[1]);
            return descriptografar;
        }

        public static bool VerificarConexaoExistente()
        {
            bool ativo;
            if (File.Exists(Environment.CurrentDirectory + @"\conexao.txt"))
            {
                ativo = true;
            }
            else
            {
                ativo = false;
            }
            return ativo;
        }

        public static string MontaStringConexao(string servidor, string porta, string baseDados, string usuario, string senha)
        {
            StringBuilder StringConexao = new StringBuilder();
            StringConexao.Append($"User Id={usuario};")
                .Append($"Password={senha};")
                .Append($"Server={servidor};")
                .Append($"Port={porta};")
                .Append($"Database={baseDados};")
                .Append($"Enlist=true;")
                .Append($"Timeout={5};"); //retirar
            return StringConexao.ToString();
        }

        public static void CriptografarConexaoBanco(string conexao, int idEmpresa)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + @"\conexao.txt"))
                {
                    File.Delete(Environment.CurrentDirectory + @"\conexao.txt");
                }
                using (FileStream fileStream = new FileStream(Environment.CurrentDirectory + @"\conexao.txt", FileMode.OpenOrCreate))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] key =
                        {
                            0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                            0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
                        };
                        aes.Key = key;

                        byte[] iv = aes.IV;
                        fileStream.Write(iv, 0, iv.Length);

                        using (CryptoStream cryptoStream = new CryptoStream(
                            fileStream,
                            aes.CreateEncryptor(),
                            CryptoStreamMode.Write))
                        {
                            using (StreamWriter encryptWriter = new StreamWriter(cryptoStream))
                            {
                                encryptWriter.WriteLine(conexao + "|" + idEmpresa);
                            }
                        }
                    }
                }
                MessageBox.Show("Configuração Salva com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Conexão não foi salva, contate o administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static string DescriptografarConexaoBanco()
        {
            try
            {
                using (FileStream fileStream = new FileStream(Environment.CurrentDirectory + @"\conexao.txt", FileMode.Open))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] iv = new byte[aes.IV.Length];
                        int numBytesToRead = aes.IV.Length;
                        int numBytesRead = 0;
                        while (numBytesToRead > 0)
                        {
                            int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                            if (n == 0) break;

                            numBytesRead += n;
                            numBytesToRead -= n;
                        }

                        byte[] key =
                        {
                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
            };

                        using (CryptoStream cryptoStream = new CryptoStream(
                           fileStream,
                           aes.CreateDecryptor(key, iv),
                           CryptoStreamMode.Read))
                        {
                            using (StreamReader decryptReader = new StreamReader(cryptoStream))
                            {
                                string decryptedMessage = decryptReader.ReadToEnd();
                                return decryptedMessage;
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"The decryption failed. {ex}");
                return null;
            }
        }

        public static string TransformarMesExtenso(int mes)
        {
            string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToLower();
            mesExtenso = char.ToUpper(mesExtenso[0]) + mesExtenso.Substring(1);
            return mesExtenso;
        }

        public static DataTable DiferencaDataTables(DataTable dataTableNotasBanco, DataTable dataTableNotasXml, int tipo)
        {
            DataTable dataTableNotasSemCanceladas = new DataTable();
            IEnumerable<DataRow> dataRowNotasSemCanceladas = dataTableNotasBanco.AsEnumerable().Where(x => x.Field<object>("xml") != null && x.Field<bool>("cancelado") == false);
            if(dataRowNotasSemCanceladas.Count() == 0)
            {
                return dataTableNotasSemCanceladas;
            }
            dataTableNotasSemCanceladas = dataRowNotasSemCanceladas.CopyToDataTable();
            DataTable dtResultadoDiferenca = new DataTable();
            dtResultadoDiferenca.Columns.Add("Numero", typeof(int));
            dtResultadoDiferenca.Columns.Add("ValorTotal", typeof(decimal));
            dtResultadoDiferenca.Columns.Add("Motivo", typeof(string));

            foreach (DataRow dr in dataTableNotasSemCanceladas.Rows)
            {
                var dtRowNotaXml = dataTableNotasXml.AsEnumerable().FirstOrDefault(x => x.Field<int>("Numero") == Convert.ToInt32(dr["Numero"]));
                if (dtRowNotaXml == null)
                {
                    if (tipo == 2)
                    {
                        dtResultadoDiferenca.Rows.Add(new object[] { dr["Numero"], dr["ValorTotal"], "Não Existe XML" });
                    }
                    else
                    {
                        dtResultadoDiferenca.Rows.Add(new object[] { dr["Numero"], dr["Total"], "Não Existe XML" });
                    }
                }
                else
                {
                    var campoValor = Convert.ToDecimal(tipo == 2 ? dr["ValorTotal"] : dr["Total"]);
                    if (campoValor != Convert.ToDecimal(dtRowNotaXml["valor"]))
                    {
                        dtResultadoDiferenca.Rows.Add(new object[] { dtRowNotaXml["numero"], dtRowNotaXml["valor"], "Valor Divergente" });
                    }
                }
            }
            return dtResultadoDiferenca;

            //DataTable dt = new DataTable();
            //dt.Columns.Add("Numero", typeof(int));
            //dt.Columns.Add("ValorTotal", typeof(decimal));

            //foreach (DataRow dr in dataTableNotasBanco.Rows)
            //{
            //    if (tipo == 2)
            //        dt.Rows.Add(new object[] { dr["Numero"], dr["ValorTotal"] });
            //    else
            //    {
            //        dt.Rows.Add(new object[] { dr["Numero"], dr["Total"] });
            //    }
            //}

            //DataTable Resultado = new DataTable("ResultDataTable");

            //using (DataSet ds = new DataSet())
            //{
            //    ds.Tables.AddRange(new DataTable[] { dt.Copy(), dataTableNotasXml.Copy() });

            //    DataColumn[] firstColumns = new DataColumn[ds.Tables[0].Columns.Count];
            //    for (int i = 0; i < firstColumns.Length; i++)
            //    {
            //        firstColumns[i] = ds.Tables[0].Columns[i];
            //    }

            //    DataColumn[] secondColumns = new DataColumn[ds.Tables[1].Columns.Count];
            //    for (int i = 0; i < secondColumns.Length; i++)
            //    {
            //        secondColumns[i] = ds.Tables[1].Columns[i];
            //    }

            //    DataRelation r1 = new DataRelation(string.Empty, firstColumns, secondColumns, false);
            //    ds.Relations.Add(r1);

            //    DataRelation r2 = new DataRelation(string.Empty, secondColumns, firstColumns, false);
            //    ds.Relations.Add(r2);

            //    for (int i = 0; i < dt.Columns.Count; i++)
            //    {
            //        Resultado.Columns.Add(dt.Columns[i].ColumnName, dt.Columns[i].DataType);
            //    }
            //    ////If FirstDataTable Row not in SecondDataTable, Add to ResultDataTable.  
            //    //Resultado.BeginLoadData();
            //    //foreach (DataRow parentrow in ds.Tables[0].Rows)
            //    //{
            //    //    DataRow[] childrows = parentrow.GetChildRows(r1);
            //    //    if (childrows == null || childrows.Length == 0)
            //    //        Resultado.LoadDataRow(parentrow.ItemArray, true);
            //    //}

            //    //If SecondDataTable Row not in FirstDataTable, Add to ResultDataTable.  
            //    foreach (DataRow parentrow in ds.Tables[1].Rows)
            //    {
            //        DataRow[] childrows = parentrow.GetChildRows(r2);
            //        if (childrows == null || childrows.Length == 0)
            //            Resultado.LoadDataRow(parentrow.ItemArray, true);
            //    }
            //    Resultado.EndLoadData();
            //}

            //return Resultado;
        }

        public static void AbrirPastaSintegra()
        {
            if (MessageBox.Show("Gostaria de Abrir a Pasta do Sintegra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string caminhoPasta = @"C:\Autocom\Sintegra\";
                if (Directory.Exists(caminhoPasta))
                {
                    Process.Start("Explorer", caminhoPasta);
                }
                else if (
                    MessageBox.Show("Pasta sintegra não existe, deseja cria-la?", "Diretório Não Existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Directory.CreateDirectory(caminhoPasta);
                    Process.Start("Explorer", caminhoPasta);
                }
            }

        }


    }
}
