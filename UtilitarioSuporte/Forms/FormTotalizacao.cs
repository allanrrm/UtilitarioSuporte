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

namespace UtilitarioSuporte.Forms
{
    public partial class FormTotalizacao : Form
    {
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
            NotaXml notaXmlEntrada = Negocio.Negocio.PreencherFormulario(notasDataTableEntrada, 0);
            NotaXml notaXmlSaida = Negocio.Negocio.PreencherFormulario(notasDataTableSaida, 1);
            NotaXml notaXmlNFCe = Negocio.Negocio.PreencherFormulario(notasDataTableNFCe, 2);

            // Nota Fiscal Entrada
            lblNumeroNotasNFeEntrada.Text = notaXmlEntrada.NumeroNotas.ToString();
            lblAutorizadaNfeEntrada.Text = notaXmlEntrada.Autorizadas.ToString();
            lblCanceladaNfeEntrada.Text = notaXmlEntrada.Canceladas.ToString();         
            lblValorNfeEntrada.Text = notaXmlEntrada.ValorTotal.ToString();
            // Nota Fiscal Saída
            lblNumeroNotasNFeSaida.Text = notaXmlSaida.NumeroNotas.ToString();
            lblAutorizadaNfeSaida.Text = notaXmlSaida.Autorizadas.ToString();
            lblCanceladaNfeSaida.Text = notaXmlSaida.Canceladas.ToString();
            lblValorNfeSaida.Text = notaXmlSaida.ValorTotal.ToString();
            // NFCe
            lblNumeroNotasNFCe.Text = notaXmlNFCe.NumeroNotas.ToString();
            lblAutorizadaNfce.Text = notaXmlNFCe.Autorizadas.ToString();
            lblCanceladaNfce.Text = notaXmlNFCe.Canceladas.ToString();
            lblValorNfce.Text = notaXmlNFCe.ValorTotal.ToString();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ValorTotalizacao(comboBoxMes.Text, textBoxAno.Text);
        }
    }
}
