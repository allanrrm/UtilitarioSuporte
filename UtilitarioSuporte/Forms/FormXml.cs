using DataAccess;
using System;
using System.Data;
using System.Windows.Forms;
using UtilitarioSuporte.Negocio;

namespace UtilitarioSuporte.Forms
{
    public partial class FormXml : Form
    {
        int tipo = 0;
        NotaXml notaXml = new NotaXml();


        public FormXml(int tipo)
        {
            InitializeComponent();
            comboBoxMes.Text = DateTime.Now.AddMonths(-1).ToString("MMMM");
            textBoxAno.Text = DateTime.Now.Year.ToString();
            this.tipo = tipo;
            ExecutarFiltroNotas(comboBoxMes.Text, textBoxAno.Text, tipo);
        }

        private void ExecutarFiltroNotas(string mes, string ano, int tipo)
        {
            DataTable notasDataTable = Conexao.PreencherFormularioDataTable(mes, ano, tipo);
            notaXml = Negocio.Negocio.PreencherFormulario(notasDataTable, tipo);
            notasDataTable.Columns.Remove("xml");
            if (tipo == 2)
            {
                notasDataTable.Columns.Remove("Recibo");
            }
            dataGridViewXml.DataSource = notasDataTable;
            lblContadorNotas.Text = notaXml.NumeroNotas.ToString();
            lblContadorAutorizadas.Text = notaXml.Autorizadas.ToString();
            lblContadorCanceladas.Text = notaXml.Canceladas.ToString();
            lblValorAutorizadas.Text = notaXml.ValorTotal.ToString();
            lblContadorNotasXml.Text = notaXml.NotasComXml.ToString();
            dataGridViewDivergente.Visible = true;
            Negocio.Negocio.ExtrairNotas(comboBoxMes.Text, textBoxAno.Text, tipo, notaXml);
            notaXml.DataTableNotasXml = Negocio.Negocio.CapturarInformacoesXml(tipo, mes);
            notaXml.CalcularValorXml(notaXml.DataTableNotasXml, tipo);
            if (tipo == 2 || tipo == 1)
            {               
                dataGridViewSerie.Visible = true;
                dataGridViewSaltados.Visible = true;
                notaXml.AgruparValorPorSerie(notaXml.DataTableNotas, tipo);
                dataGridViewSerie.DataSource = notaXml.DataTableSerie;
                dataGridViewSaltados.DataSource = notaXml.VerificarNumeracaoSaltada(notaXml.DataTableNotas);
                dataGridViewNotasSemXml.DataSource = notaXml.DataTableNotasSemXml;
            }

            lblValorXml.Text = notaXml.ValorTotalXml.ToString();
            dataGridViewDivergente.DataSource = Funcoes.DiferencaDataTables(notaXml.DataTableNotas, notaXml.DataTableNotasXml, tipo);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ExecutarFiltroNotas(comboBoxMes.Text, textBoxAno.Text, tipo);
        }

    }
}
