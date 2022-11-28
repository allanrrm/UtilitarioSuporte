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
    public partial class FormDadosXml : Form
    {
        public FormDadosXml(int tipo)
        {
            InitializeComponent();

            comboBoxMes.Text = DateTime.Now.AddMonths(-1).ToString("MMMM");
            textBoxAno.Text = DateTime.Now.Year.ToString();
            ExecutarFiltroNotas(comboBoxMes.Text, textBoxAno.Text, tipo);
        }

        private void ExecutarFiltroNotas(string mes, string ano, int tipo)
        {
            DAO.PreencherFormulario(mes, ano, tipo);
        }
    }
}
