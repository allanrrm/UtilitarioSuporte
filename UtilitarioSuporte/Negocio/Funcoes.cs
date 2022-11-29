using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using Npgsql;
using System.Security.Cryptography;
using System.Data;
using UtilitarioSuporte.DataAccess;
using System.Xml;

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
                                encryptWriter.WriteLine(conexao+"|"+idEmpresa);
                            }
                        }
                    }
                }
                MessageBox.Show("Configuração Salva com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Conexão não foi salva, contate o administrador", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
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
                               string decryptedMessage =  decryptReader.ReadToEnd();
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

        public static DataTable DiferencaDataTables(DataTable dtNfceLoja, DataTable dtNfceCaixa)
        {

            DataTable Resultado = new DataTable("ResultDataTable");

            using (DataSet ds = new DataSet())
            {
                ds.Tables.AddRange(new DataTable[] { dtNfceLoja.Copy(), dtNfceCaixa.Copy() });

                DataColumn[] firstColumns = new DataColumn[ds.Tables[0].Columns.Count];
                for (int i = 0; i < firstColumns.Length; i++)
                {
                    firstColumns[i] = ds.Tables[0].Columns[i];
                }

                DataColumn[] secondColumns = new DataColumn[ds.Tables[1].Columns.Count];
                for (int i = 0; i < secondColumns.Length; i++)
                {
                    secondColumns[i] = ds.Tables[1].Columns[i];
                }

                DataRelation r1 = new DataRelation(string.Empty, firstColumns, secondColumns, false);
                ds.Relations.Add(r1);

                DataRelation r2 = new DataRelation(string.Empty, secondColumns, firstColumns, false);
                ds.Relations.Add(r2);

                for (int i = 0; i < dtNfceLoja.Columns.Count; i++)
                {
                    Resultado.Columns.Add(dtNfceLoja.Columns[i].ColumnName, dtNfceLoja.Columns[i].DataType);
                }
                ////If FirstDataTable Row not in SecondDataTable, Add to ResultDataTable.  
                //Resultado.BeginLoadData();
                //foreach (DataRow parentrow in ds.Tables[0].Rows)
                //{
                //    DataRow[] childrows = parentrow.GetChildRows(r1);
                //    if (childrows == null || childrows.Length == 0)
                //        Resultado.LoadDataRow(parentrow.ItemArray, true);
                //}

                //If SecondDataTable Row not in FirstDataTable, Add to ResultDataTable.  
                foreach (DataRow parentrow in ds.Tables[1].Rows)
                {
                    DataRow[] childrows = parentrow.GetChildRows(r2);
                    if (childrows == null || childrows.Length == 0)
                        Resultado.LoadDataRow(parentrow.ItemArray, true);
                }
                Resultado.EndLoadData();
            }

            return Resultado;
        }


    }
}
