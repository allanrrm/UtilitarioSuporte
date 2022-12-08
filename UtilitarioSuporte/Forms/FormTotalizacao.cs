using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitarioSuporte.Negocio;
using static UtilitarioSuporte.Negocio.Funcoes;

namespace UtilitarioSuporte.Forms
{
    public partial class FormTotalizacao : Form
    {
        NotaXml notaXmlEntrada;
        NotaXml notaXmlSaida;
        NotaXml notaXmlNFCe;
        Dictionary<string, bool> dicRelatorios;

        public FormTotalizacao()
        {
            InitializeComponent();
            comboBoxMes.Text = DateTime.Now.AddMonths(-1).ToString("MMMM");
            textBoxAno.Text = DateTime.Now.Year.ToString();
            ValorTotalizacao(comboBoxMes.Text, textBoxAno.Text);
        }

        public void ValorTotalizacao(string mes, string ano)
        {
            DataTable notasDataTableEntrada = Conexao.PreencherFormularioDataTable(mes, ano, 0);
            DataTable notasDataTableSaida = Conexao.PreencherFormularioDataTable(mes, ano, 1);
            DataTable notasDataTableNFCe = Conexao.PreencherFormularioDataTable(mes, ano, 2);
            notaXmlEntrada = Negocio.Negocio.PreencherFormulario(notasDataTableEntrada, 0);
            notaXmlSaida = Negocio.Negocio.PreencherFormulario(notasDataTableSaida, 1);
            notaXmlNFCe = Negocio.Negocio.PreencherFormulario(notasDataTableNFCe, 2);

            // Nota Fiscal Entrada
            lblNumeroNotasNFeEntrada.Text = notaXmlEntrada.NumeroNotas.ToString();
            lblAutorizadaNfeEntrada.Text = notaXmlEntrada.Autorizadas.ToString();
            lblCanceladaNfeEntrada.Text = notaXmlEntrada.Canceladas.ToString();         
            lblValorNfeEntrada.Text = notaXmlEntrada.ValorTotal.ToString("F2");
            // Nota Fiscal Saída
            lblNumeroNotasNFeSaida.Text = notaXmlSaida.NumeroNotas.ToString();
            lblAutorizadaNfeSaida.Text = notaXmlSaida.Autorizadas.ToString();
            lblCanceladaNfeSaida.Text = notaXmlSaida.Canceladas.ToString();
            lblValorNfeSaida.Text = notaXmlSaida.ValorTotal.ToString("F2");
            // NFCe
            lblNumeroNotasNFCe.Text = notaXmlNFCe.NumeroNotas.ToString();
            lblAutorizadaNfce.Text = notaXmlNFCe.Autorizadas.ToString();
            lblCanceladaNfce.Text = notaXmlNFCe.Canceladas.ToString();
            lblValorNfce.Text = notaXmlNFCe.ValorTotal.ToString("F2");


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ValorTotalizacao(comboBoxMes.Text, textBoxAno.Text);
        }

        private void btnGerarTicket_Click(object sender, EventArgs e)
        {
            dicRelatorios = new Dictionary<string, bool>()
            {
                { "ListagemNFCe" , Convert.ToBoolean(checkBoxListagemNFCe.Checked)},
                { "Listagem de NFCe - Detalhado" , Convert.ToBoolean(checkBoxListagemNFCeDetalhado.Checked) },
                { "Listagem de NFCe Tributado por Dia" , Convert.ToBoolean(checkBoxListagemNFCeTributado.Checked) },
                { "Apuração de Entrada" , Convert.ToBoolean(checkBoxApuracaoEntrada.Checked) },
                { "Listagem de Saída" , Convert.ToBoolean(checkBoxListagemSaida.Checked) },
                { "Relatório Monofásico" , Convert.ToBoolean(checkBoxMonofasico.Checked) },
                { "NFCe - Cancelada" , Convert.ToBoolean(checkBoxListagemNFCeCancelada.Checked) },
                { "Saída - Cancelada" , Convert.ToBoolean(checkBoxSaidaCancelada.Checked) },
                { "ICMS - Apuração" , Convert.ToBoolean(checkBoxICMSApuracao.Checked) },
                { "NFe - Inutilizadas" , Convert.ToBoolean(checkBoxNFeInutilizadas.Checked) },
                { "NFCe - Inutilizadas" , Convert.ToBoolean(checkBoxNFCeInutilizada.Checked) },
                { "Outros", Convert.ToBoolean(checkBoxOutros.Checked)}
            };

            

            GerarArquivoPDF(notaXmlEntrada, notaXmlSaida, notaXmlNFCe, dicRelatorios, richTextBoxObservacoes.Text, comboBoxMes.Text, textBoxAno.Text);
        }
    }
}
