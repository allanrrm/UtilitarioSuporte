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
          
            DataTable notasDataTable = Contexto.PreencherFormularioDataTable(mes, ano, tipo);
            if (notasDataTable == null) //Caso não seja feita a conexão, esse DataTable terá o valor de nulo e retornará o formulario em branco
            {
                Funcoes.MessagemRetornoConexao(false);               
                return;
            }
            dataGridViewXml.Visible = true;
            notaXml = Negocio.Contexto.PreencherFormulario(notasDataTable, tipo);
            notasDataTable.Columns.Remove("xml");
            if (tipo == 2)
            {
                notasDataTable.Columns.Remove("Recibo");
            }
            dataGridViewXml.DataSource = notasDataTable;
            lblContadorNotas.Text = notaXml.NumeroNotas.ToString();
            lblContadorAutorizadas.Text = notaXml.Autorizadas.ToString();
            lblContadorCanceladas.Text = notaXml.Canceladas.ToString();
            lblValorAutorizadas.Text = notaXml.ValorTotal.ToString("F2");
            lblContadorNotasXml.Text = notaXml.NotasComXml.ToString();
            dataGridViewDivergente.Visible = true;
            Negocio.Contexto.ExtrairNotas(comboBoxMes.Text, textBoxAno.Text, tipo, notaXml);
            notaXml.DataTableNotasXml = Negocio.Contexto.CapturarInformacoesXml(tipo, mes);
            notaXml.CalcularValorXml(notaXml.DataTableNotasXml, tipo);
            if (tipo == 2 || tipo == 1)
            {               
                dataGridViewSerie.Visible = true;
                dataGridViewSaltados.Visible = true;
                notaXml.AgruparValorPorSerie(notaXml.DataTableNotas, tipo);
                dataGridViewSerie.DataSource = notaXml.DataTableSerie;
                dataGridViewSaltados.DataSource = notaXml.VerificarNumeracaoSaltada(notaXml.DataTableNotas);
                dataGridViewNotasSemXml.Visible = true;                
                notaXml.ExtrairNotasSemXML(notaXml.DataTableNotas, tipo);
                dataGridViewNotasSemXml.DataSource = notaXml.DataTableNotasSemXml;
            }

            lblValorXml.Text = notaXml.ValorTotalXml.ToString("F2");
            dataGridViewDivergente.DataSource = Funcoes.DiferencaDataTables(notaXml.DataTableNotas, notaXml.DataTableNotasXml, tipo);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ExecutarFiltroNotas(comboBoxMes.Text, textBoxAno.Text, tipo);
        }

    }
}
