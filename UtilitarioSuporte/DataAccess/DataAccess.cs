using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;
using System.Xml;
using UtilitarioSuporte.DataAccess;
using UtilitarioSuporte.Negocio;
using static UtilitarioSuporte.Recursos.MessageBoxPersonalizada;

namespace DataAccess
{
    public class Conexao
    {
        public Conexao()
        {

        }
        public static NpgsqlConnection ConexaoBase(string stringConexao)
        {

            var conn = new NpgsqlConnection(stringConexao);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                conn.Close();
            }
            return conn;

        }
        public static NpgsqlConnection CriarConexaoBase(string stringConexao)
        {

            var conn = new NpgsqlConnection(stringConexao);
            try
            {
                conn.Open();
                MessageBox.Show("Conexão efetuada com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Não foi possivel estabelecer uma conexao com o servidor, verifique as informações e tente novamente.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            return conn;

        }
        public static DataTable ExecReader(NpgsqlCommand cmd, NpgsqlConnection conn)
        {
            try
            {
                cmd.Connection = conn;
                NpgsqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ConectarBancoDados(string servidor, string porta, string baseDados, string usuario, string senha)
        {
            string conexao = Funcoes.MontaStringConexao(servidor, porta, baseDados, usuario, senha);
            NpgsqlConnection conn = Conexao.CriarConexaoBase(conexao);
            DataTable empresas = ConsultarEmpresas(conn);
            return empresas;
        }
        public static DataTable ConsultarEmpresas(NpgsqlConnection conn)
        {
            NpgsqlCommand empresas = ComandosSQL.CmdEmpresas(conn);
            DataTable dtEmpresas = Conexao.ExecReader(empresas, conn);
            return dtEmpresas;
        }
        public static void SalvarConfiguracaoBaseDados(string servidor, string porta, string baseDados, string usuario, string senha, int idEmpresa)
        {
            string conexao = Funcoes.MontaStringConexao(servidor, porta, baseDados, usuario, senha);
            Funcoes.CriptografarConexaoBanco(conexao, idEmpresa);
        }
        public static void ExtrairBase(DataTable dtNotas, int OpcaoComando, string mes, string ano)
        {
            DateTime datainicial = DateTime.Parse("1." + mes + ano);
            DateTime datafinal = (datainicial.AddMonths(1).AddDays(-1));
            XmlDocument xml = new XmlDocument();
            XmlDocument recibo, xmlNFCe;
            string nomeArquivo = null;
            IEnumerable<DataRow> query = dtNotas.AsEnumerable().Where(x => x.Field<object>("xml") != null);
            DataTable dataTableNotas = query.CopyToDataTable<DataRow>();
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
                        caminhoPasta = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\NFCe - (xml) - Temp\";
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

        public static void ExtrairBaseNotasCanceladas(DataTable dtNotas, int OpcaoComando, string mes, string ano)
        {
            DateTime datainicial = DateTime.Parse("1." + mes + ano);
            DateTime datafinal = (datainicial.AddMonths(1).AddDays(-1));
            XmlDocument xml = new XmlDocument();
            XmlDocument recibo, xmlNFCe;
            string nomeArquivo = null;
            IEnumerable<DataRow> query = dtNotas.AsEnumerable().Where(x => x.Field<object>("xml") != null && x.Field<bool>("cancelado") == true);
            try
            {
                DataTable dataTableNotas = query.CopyToDataTable<DataRow>();


                foreach (DataRow drItemNfce in dtNotas.Rows)
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
                            caminhoPasta = @"C:\Autocom\Sintegra\" + datainicial.Year + @"\Sintegra " + Funcoes.TransformarMesExtenso(datainicial.Month) + @"\NFCe - (xml) - Canceladas - Temp\";
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
            }catch (Exception ex)
            {

            }
        }
    }
    }

