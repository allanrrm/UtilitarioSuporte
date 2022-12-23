using iTextSharp.text;
using iTextSharp.text.pdf;
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
            string conexao = "";
            try
            {
            conexao = DescriptografarConexaoBanco().ToString();
            //Separação da StringConexão e do IdEmpresa que está criptografado no arquivo Configuração.                   
            string[] infoConf = conexao.Split('|');
            descriptografar.Add(infoConf[0]);
            descriptografar.Add(infoConf[1]);
            }
            catch
            {            
                return descriptografar;
            }

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
        public static string MontaStringConexao(string servidor, string porta, string usuario, string senha)
        {
            StringBuilder StringConexao = new StringBuilder();
            StringConexao.Append($"User Id={usuario};")
                .Append($"Password={senha};")
                .Append($"Server={servidor};")
                .Append($"Port={porta};")
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
            catch
            {
                
                return "";
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
        public static void GerarArquivoPDF(NotaXml NFeEntrada, NotaXml NFeSaida, NotaXml NFCe, Dictionary<string, bool> dicRelatorios, string observacoes, string mes, string ano)
        {
            DateTime datainicial = DateTime.Parse("1." + mes + ano);
            DateTime datafinal = (datainicial.AddMonths(1).AddDays(-1));
            Dictionary<string, bool> relatoriosEmitidos = new Dictionary<string, bool>();
            foreach (KeyValuePair<string, bool> e in dicRelatorios)
            {
                if(e.Value == true)
                {               
                    relatoriosEmitidos.Add(e.Key, e.Value);
                }
            }

            Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
            doc.SetMargins(40, 40, 40, 80);//estibulando o espaçamento das margens que queremos
            doc.AddCreationDate();//adicionando as configuracoes
            //caminho onde sera criado o pdf + nome desejado                   
            string caminhoPasta = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\";
            if (!Directory.Exists(caminhoPasta))
            {
                Directory.CreateDirectory(caminhoPasta);
            }
            string caminho = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\Ticket.pdf";
            //criando o arquivo pdf embranco, passando como parametro a variavel doc criada acima e a variavel caminho
            //tambem criada acima.
            //OBS: o nome sempre deve ser terminado com .pdf  
            PdfWriter writer = PdfWriter.GetInstance(doc, new
            FileStream(caminho, FileMode.Create));
            doc.Open();

            Paragraph titulo = new Paragraph("Ticket",new Font(Font.NORMAL, 18));
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            titulo = new Paragraph("NF-e Entrada", new Font(Font.NORMAL, 14));
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            string linha = $"Numero de Notas: {NFeEntrada.NumeroNotas}\r\n" +
                           $"Autorizadas: {NFeEntrada.Autorizadas}\r\n" +
                           $"Canceladas: {NFeEntrada.Canceladas}\r\n" +
                           $"Valor(Autorizadas): {NFeEntrada.ValorTotal}\r\n\r\n";
            Paragraph paragrafo = new Paragraph(linha,
            new Font(Font.NORMAL, 14));
            paragrafo.Alignment = Element.ALIGN_LEFT;
            doc.Add(paragrafo);


            titulo = new Paragraph("NF-e Saída", new Font(Font.NORMAL, 14));
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            linha = $"Numero de Notas: {NFeSaida.NumeroNotas}\r\n" +
                           $"Autorizadas: {NFeSaida.Autorizadas}\r\n" +
                           $"Canceladas: {NFeSaida.Canceladas}\r\n" +
                           $"Valor(Autorizadas): {NFeSaida.ValorTotal}\r\n\r\n";
            paragrafo = new Paragraph(linha,
            new Font(Font.NORMAL, 14));
            paragrafo.Alignment = Element.ALIGN_LEFT;
            doc.Add(paragrafo);

            titulo = new Paragraph("NFC-e", new Font(Font.NORMAL, 14));
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            linha = $"Numero de Notas: {NFCe.NumeroNotas}\r\n" +
                           $"Autorizadas: {NFCe.Autorizadas}\r\n" +
                           $"Canceladas: {NFCe.Canceladas}\r\n" +
                           $"Valor(Autorizadas): {NFCe.ValorTotal}\r\n\r\n";
            paragrafo = new Paragraph(linha,
            new Font(Font.NORMAL, 14));
            paragrafo.Alignment = Element.ALIGN_LEFT;
            doc.Add(paragrafo);

            titulo = new Paragraph("Relatorios Emitidos\r\n", new Font(Font.NORMAL, 14));
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            foreach(KeyValuePair<string, bool> e in relatoriosEmitidos)
            {
                linha = $"- {e.Key}\r\n";
                paragrafo = new Paragraph(linha,
                new Font(Font.NORMAL, 14));
                paragrafo.Alignment = Element.ALIGN_LEFT;
                doc.Add(paragrafo);
            }
            string texto = $"\r\n";
            paragrafo = new Paragraph(texto + observacoes,
            new Font(Font.NORMAL, 14));
            paragrafo.Alignment = Element.ALIGN_LEFT;
            doc.Add(paragrafo);
            //Paragraph paragrafo = new Paragraph("",
            //new Font(Font.NORMAL, 14));
            ////etipulando o alinhamneto
            //paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            ////Alinhamento Justificado
            ////adicioando texto

            ////AQUI ONDE VAMOS ADICIONAR A VARIAVEL DO TIPO "Font"
            //paragrafo.Font = new Font(Font.NORMAL, 14,
            //(int)System.Drawing.FontStyle.Regular);

            doc.Close();
        }
        public static void MessagemRetornoConexao(bool retorno)
        {
            if (retorno == true)
            {
                MessageBox.Show("Conexao efetuada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não foi possivel estabelecer comunicação com o banco de Dados, por favor, verifique as informações de conexao e tente novamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public static string SelecionarPasta()
        {
            string resultado;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selecione a Pasta";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                resultado = folderBrowserDialog.SelectedPath;
            }
            else
            {
                resultado = "";
            }
            return resultado;
        }
        public static string SelecionarArquivo()
        {
            string resultado;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione o arquivo de backup";
            openFileDialog.Filter = "Arquivo Sql (*.sql;*.zip;.rar;.7zip)|*.sql;*.zip";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                resultado = openFileDialog.FileName;
            }
            else
            {
                resultado = "";
            }
            return resultado;
        }
    }
}
