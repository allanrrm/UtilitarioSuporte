using System;
using System.Windows.Forms;
using UtilitarioSuporte.Negocio;

namespace UtilitarioSuporte.Forms
{
    public partial class FormExterno : Form
    {
        public FormExterno()
        {
            InitializeComponent();
            ExecutarConsultaEmpresa();
        }

        private void ExecutarConsultaEmpresa()
        {
            Contexto.ConsultaEmpresa();
        }
    }
}
