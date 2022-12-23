using DataAccess;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UtilitarioSuporte.DataAccess;

namespace UtilitarioSuporte.Negocio
{
    public class Contexto
    {    
        public static NotaXml PreencherFormulario(DataTable dataTableNotas, int tipo)
        {
            NotaXml notaXml = new NotaXml();
            if (tipo == 2)
            {
                notaXml.ExtrairResultadosNFCe(dataTableNotas);
            }
            else
            {
                notaXml.ExtrairResultadosNFe(dataTableNotas);
            }
            
            return notaXml;
        }

        public static DataTable PreencherFormularioDataTable(string mes, string ano, int tipo)
        {
            DataTable dataTable = Conexao.PreencherDataTable(mes, ano, tipo);
            return dataTable;
        }

        public static void ExtrairNotas(string mes, string ano, int tipo, NotaXml notaXml)
        {
            DataTable dataTableNotas = notaXml.DataTableNotas;
            ExtrairBase(dataTableNotas, tipo, mes, ano);
            ExtrairBaseNotasCanceladas(dataTableNotas, tipo, mes, ano);
        }

        public static void RecuperarBaseDados(string servidor, string porta, string usuario, string senha, string arquivoBaseDados, string caminhoPSQL, string nomeBase)
        {
            if (Path.GetExtension(arquivoBaseDados) == ".zip")
            {
                string caminhoExtracaoBaseDados = Environment.CurrentDirectory;
                caminhoExtracaoBaseDados = Path.GetFullPath(caminhoExtracaoBaseDados);
                try
                {
                    using (ZipArchive archive = ZipFile.OpenRead(arquivoBaseDados))
                    {
                        if (Path.GetExtension(archive.Entries[0].ToString()) != ".sql")
                        {
                            MessageBox.Show("Não foi possivel extrair o banco de dados");
                            return;
                        }
                        ZipFile.ExtractToDirectory(arquivoBaseDados, Environment.CurrentDirectory);
                        arquivoBaseDados = Environment.CurrentDirectory + @"\" + archive.Entries[0].ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possivel extrair o banco de dados");
                    return;
                }
            
            }
            string conexao = Funcoes.MontaStringConexao(servidor, porta, usuario, senha);
            bool retorno = Conexao.Restore(caminhoPSQL,arquivoBaseDados,usuario,nomeBase,senha, conexao);
            if (retorno == false)
            {
                MessageBox.Show("Base já existente ou campo em branco, Digite o nome da base novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                File.Delete(arquivoBaseDados);
            }

            MessageBox.Show("Base recuperada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            File.Delete(arquivoBaseDados);
        }

        public static DataTable CapturarInformacoesXml(int tipo, string mes)
        {

            string diretorio = "";
            if (tipo == 0)
            {
                diretorio = $@"C:\AutoCom\Sintegra\2022\Sintegra {mes}\NFe - Entrada(xml)";
            }
            else if(tipo == 1)
            {
                diretorio = $@"C:\AutoCom\Sintegra\2022\Sintegra {mes}\NFe - Saída(xml)";
            }else if(tipo == 2)
            {
                diretorio = $@"C:\AutoCom\Sintegra\2022\Sintegra {mes}\NFCe - (xml)";
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("numero", typeof(int));
            dt.Columns.Add("valor", typeof(decimal));

            string[] arquivos = null;
            if (!string.IsNullOrEmpty(diretorio))
            {
                DirectoryInfo dir = new DirectoryInfo(diretorio);
                if (!dir.Exists)
                {
                    return dt;

                }
                arquivos = Directory.GetFiles(diretorio, "*.xml");
                foreach (string arquivo in arquivos)
                {
                    XmlDocument documento = new XmlDocument();
                    documento.Load(arquivo);
                    XmlElement xmlelement = documento.DocumentElement;
                    XmlNodeList valorTotal = xmlelement.GetElementsByTagName("vNF");
                    XmlNodeList numero = xmlelement.GetElementsByTagName("nNF");
                    dt.Rows.Add(numero.Item(0).InnerXml, valorTotal.Item(0).InnerXml.Replace(".", ","));
                }

            }
            return dt;
        }
        public static void ExtrairBase(DataTable dtNotas, int OpcaoComando, string mes, string ano)
        {
            DateTime datainicial = DateTime.Parse("1." + mes + ano);
            DateTime datafinal = (datainicial.AddMonths(1).AddDays(-1));
            XmlDocument xml = new XmlDocument();
            XmlDocument recibo, xmlNFCe;
            DataTable dataTableNotas = new DataTable();
            string nomeArquivo = null;
            IEnumerable<DataRow> dataRowNotasSemCanceladas = dtNotas.AsEnumerable().Where(x => x.Field<object>("xml") != null && x.Field<bool>("cancelado") == false);
            try
            {
                dataTableNotas = dataRowNotasSemCanceladas.CopyToDataTable();
                foreach (DataRow drItemNfce in dataTableNotas.Rows)
                {
                    string caminhoPasta = "";
                    if (OpcaoComando == 0)
                    {
                        caminhoPasta = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\NFe - Entrada(xml)\";
                        xml.LoadXml(System.Text.Encoding.UTF8.GetString((byte[])drItemNfce[6]));
                        nomeArquivo = $"{caminhoPasta}\\{drItemNfce[5]}-nfe.xml";
                    }
                    else if (OpcaoComando == 1)
                    {
                        caminhoPasta = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\NFe - Saída(xml)\";
                        xml.LoadXml(System.Text.Encoding.UTF8.GetString((byte[])drItemNfce[6]));
                        nomeArquivo = $"{caminhoPasta}\\{drItemNfce[5]}-nfe.xml";
                    }
                    else if (OpcaoComando == 2)
                    {
                        if (drItemNfce["recibo"].ToString() != "")
                        {

                            caminhoPasta = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\NFCe - (xml)\";
                            xmlNFCe = new XmlDocument();
                            xmlNFCe.LoadXml(System.Text.Encoding.UTF8.GetString((byte[])drItemNfce["xml"]));
                            XmlNode nodeNFe_Original = xmlNFCe.GetElementsByTagName("NFe").Item(0);

                            recibo = new XmlDocument();

                            recibo.LoadXml(System.Text.Encoding.UTF8.GetString((byte[])drItemNfce["recibo"]));
                            var protNFe_Original = recibo.GetElementsByTagName("protNFe").Item(0);

                            #region Criando novo XML com a Tag/node pai nfProc
                            xml = new XmlDocument();
                            XmlNode nfeProc = xml.CreateElement("nfeProc");

                            xml.AppendChild(nfeProc);
                            XmlAttribute versao = xml.CreateAttribute("versao");
                            versao.Value = "4.00";

                            nfeProc.Attributes.Append(versao);
                            XmlAttribute xmlns = xml.CreateAttribute("xmlns");
                            xmlns.Value = "http://www.portalfiscal.inf.br/nfe";
                            nfeProc.Attributes.Append(xmlns);
                            #endregion

                            #region Importando as tags/Nodes dos Xmls recuperados do bando do Loja para o novo XML
                            //nodeNFe_Original.Attributes.RemoveNamedItem("xmlns");
                            //protNFe_Original.Attributes.RemoveNamedItem("xmlns");
                            //protNFe_Original.FirstChild.Attributes.RemoveNamedItem("Id");

                            XmlNode nodeNFe_Importado = xml.ImportNode(nodeNFe_Original, true);
                            xml.FirstChild.AppendChild(nodeNFe_Importado);

                            XmlNode protNFe_Importado = xml.ImportNode(protNFe_Original, true);
                            xml.FirstChild.AppendChild(protNFe_Importado);
                            #endregion

                            #region Removendo atributos para igualar ao arquivo -procNfe que o sistema Gera
                            xml.GetElementsByTagName("NFe").Item(0).Attributes.RemoveNamedItem("xmlns");
                            xml.GetElementsByTagName("protNFe").Item(0).Attributes.RemoveNamedItem("xmlns");
                            xml.GetElementsByTagName("infProt").Item(0).Attributes.RemoveNamedItem("Id");
                            #endregion
                            nomeArquivo = $"{caminhoPasta}\\NFCe-{drItemNfce[5]}-procNfe.xml";

                        }
                        else
                        {
                            caminhoPasta = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\NFCe - (xml)\";
                            xml.LoadXml(System.Text.Encoding.UTF8.GetString((byte[])drItemNfce[6]));
                            nomeArquivo = $"{caminhoPasta}\\NFCe-{drItemNfce[5]}-temp.xml";
                        }



                    }


                    if (!Directory.Exists(caminhoPasta))
                    {
                        Directory.CreateDirectory(caminhoPasta);
                    }

                    if (File.Exists(nomeArquivo))
                    {
                        File.Delete(nomeArquivo);
                    }

                    using (var arquivoXML = new StreamWriter(nomeArquivo))
                    {
                        arquivoXML.Write(xml.InnerXml);
                    }
                }
            }
            catch
            {

            }
        }
        public static void ExtrairBaseNotasCanceladas(DataTable dtNotas, int OpcaoComando, string mes, string ano)
        {
            DateTime datainicial = DateTime.Parse("1." + mes + ano);
            DateTime datafinal = (datainicial.AddMonths(1).AddDays(-1));
            XmlDocument xml = new XmlDocument();
            XmlDocument recibo, xmlNFCe;
            string nomeArquivo = null;
            DataTable dataTableNotas = new DataTable();
            IEnumerable<DataRow> query = dtNotas.AsEnumerable().Where(x => x.Field<object>("xml") != null && x.Field<bool>("cancelado") == true);
            try
            {
                dataTableNotas = query.CopyToDataTable();

                foreach (DataRow drItemNfce in dataTableNotas.Rows)
                {
                    string caminhoPasta = "";
                    if (OpcaoComando == 1)
                    {
                        caminhoPasta = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\NFe - Saída(xml) - Canceladas\";
                        xml.LoadXml(System.Text.Encoding.UTF8.GetString((byte[])drItemNfce[6]));
                        nomeArquivo = $"{caminhoPasta}\\{drItemNfce[5]}-nfe.xml";
                    }
                    else if (OpcaoComando == 2)
                    {
                        if (drItemNfce["recibo"].ToString() != "")
                        {
                            caminhoPasta = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\NFCe - (xml) - Canceladas\";
                            xmlNFCe = new XmlDocument();
                            xmlNFCe.LoadXml(System.Text.Encoding.UTF8.GetString((byte[])drItemNfce["xml"]));
                            XmlNode nodeNFe_Original = xmlNFCe.GetElementsByTagName("NFe").Item(0);

                            recibo = new XmlDocument();

                            recibo.LoadXml(System.Text.Encoding.UTF8.GetString((byte[])drItemNfce["recibo"]));
                            var protNFe_Original = recibo.GetElementsByTagName("protNFe").Item(0);

                            #region Criando novo XML com a Tag/node pai nfProc
                            xml = new XmlDocument();
                            XmlNode nfeProc = xml.CreateElement("nfeProc");

                            xml.AppendChild(nfeProc);
                            XmlAttribute versao = xml.CreateAttribute("versao");
                            versao.Value = "4.00";

                            nfeProc.Attributes.Append(versao);
                            XmlAttribute xmlns = xml.CreateAttribute("xmlns");
                            xmlns.Value = "http://www.portalfiscal.inf.br/nfe";
                            nfeProc.Attributes.Append(xmlns);
                            #endregion

                            #region Importando as tags/Nodes dos Xmls recuperados do bando do Loja para o novo XML
                            //nodeNFe_Original.Attributes.RemoveNamedItem("xmlns");
                            //protNFe_Original.Attributes.RemoveNamedItem("xmlns");
                            //protNFe_Original.FirstChild.Attributes.RemoveNamedItem("Id");

                            XmlNode nodeNFe_Importado = xml.ImportNode(nodeNFe_Original, true);
                            xml.FirstChild.AppendChild(nodeNFe_Importado);

                            XmlNode protNFe_Importado = xml.ImportNode(protNFe_Original, true);
                            xml.FirstChild.AppendChild(protNFe_Importado);
                            #endregion

                            #region Removendo atributos para igualar ao arquivo -procNfe que o sistema Gera
                            xml.GetElementsByTagName("NFe").Item(0).Attributes.RemoveNamedItem("xmlns");
                            xml.GetElementsByTagName("protNFe").Item(0).Attributes.RemoveNamedItem("xmlns");
                            xml.GetElementsByTagName("infProt").Item(0).Attributes.RemoveNamedItem("Id");
                            #endregion
                            nomeArquivo = $"{caminhoPasta}\\NFCe-{drItemNfce[5]}-procNfe.xml";
                        }
                        else
                        {
                            caminhoPasta = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\NFCe - (xml) - Canceladas\";
                            xml.LoadXml(System.Text.Encoding.UTF8.GetString((byte[])drItemNfce[6]));
                            nomeArquivo = $"{caminhoPasta}\\NFCe-{drItemNfce[5]}-procNfe.xml";
                        }

                    }


                    if (!Directory.Exists(caminhoPasta))
                    {
                        Directory.CreateDirectory(caminhoPasta);
                    }

                    if (File.Exists(nomeArquivo))
                    {
                        File.Delete(nomeArquivo);
                    }

                    using (var arquivoXML = new StreamWriter(nomeArquivo))
                    {
                        arquivoXML.Write(xml.InnerXml);
                    }
                }
            }
            catch
            {

            }
        }
        public static DataTable ConexaoBancoDados(string servidor, string porta, string baseDados, string usuario, string senha)
        {         
            string conexao = Funcoes.MontaStringConexao(servidor, porta, baseDados, usuario, senha);
            bool retorno = Conexao.TestarConexao(conexao);
            if(retorno == true)
            {
                DataTable dataTableEmpresa = Conexao.ConectarBancoDados(conexao);
                Funcoes.MessagemRetornoConexao(retorno);
                return dataTableEmpresa;
            }
            else
            {
                Funcoes.MessagemRetornoConexao(retorno);
                return null;
            }

        }
        public static bool ConexaoBancoDados(string servidor, string porta, string usuario, string senha) //Método Sobreescrito para Conexão sem base criada
        {
            string conexao = Funcoes.MontaStringConexao(servidor, porta, "postgres" ,usuario, senha);
            bool retorno = Conexao.TestarConexao(conexao);
            if( retorno == true)
            {
                Funcoes.MessagemRetornoConexao(retorno);
                return retorno;
            }
            else
            {
                Funcoes.MessagemRetornoConexao(retorno);
                return retorno;
            }
            

        }
        public static void ConexaoBancoCriarConfiguracao(string servidor, string porta, string baseDados, string usuario, string senha, int idEmpresa)
        {
            string conexao = Conexao.SalvarConfiguracaoBaseDados(servidor, porta, baseDados, usuario, senha, idEmpresa);
            Funcoes.CriptografarConexaoBanco(conexao, idEmpresa);
        }

        public static void ConsultaEmpresa()
        {
            List<string> informacaoConfiguracao = Funcoes.DescriptografarStringConexao();

        }
    }
}
