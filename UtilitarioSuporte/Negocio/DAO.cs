using DataAccess;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using UtilitarioSuporte.DataAccess;

namespace UtilitarioSuporte.Negocio
{
    public class DAO
    {

        public static DataTable PreencherFormularioDataTable(string mes, string ano, int tipo)
        {
            List<string> informacaoConfiguracao = Funcoes.DescriptografarStringConexao();
            NpgsqlConnection conn = Conexao.ConexaoBase(informacaoConfiguracao[0]);
            NpgsqlCommand comando = ComandosSQL.CmdConsultarNotasNFe(conn, mes, ano, tipo, informacaoConfiguracao[1]);
            DataTable dataTableNotas = Conexao.ExecReader(comando, conn);
            return dataTableNotas;

        }
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
        public static void ExtrairNotas(string mes, string ano, int tipo, NotaXml notaXml)
        {
            DataTable dataTableNotas = notaXml.DataTableNotas;
            Conexao.ExtrairBase(dataTableNotas, tipo, mes, ano);
            Conexao.ExtrairBaseNotasCanceladas(dataTableNotas, tipo, mes, ano);
        }
        public static DataTable CapturarInformacoesXml(int tipo)
        {
            string diretorio = "";
            if (tipo == 0)
            {
                diretorio = @"C:\AutoCom\Sintegra\2022\Sintegra Outubro\NFe - Entrada(xml)";
            }
            else if(tipo == 1)
            {
                diretorio = @"C:\AutoCom\Sintegra\2022\Sintegra Outubro\NFe - Saída(xml)";
            }else if(tipo == 2)
            {
                diretorio = @"C:\AutoCom\Sintegra\2022\Sintegra Outubro\NFCe - (xml)";
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
                    throw new DirectoryNotFoundException("O Diretorio Não Existe");

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
    }
}
