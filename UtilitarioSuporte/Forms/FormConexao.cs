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
using DataAccess;

namespace UtilitarioSuporte
{
    public partial class FormConexao : Form
    {
  
        public FormConexao()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            DataTable dataTableEmpresa = Conexao.ConectarBancoDados(textBoxIpServidor.Text, textBoxPorta.Text, textBoxBaseDados.Text, textBoxUsuario.Text, textBoxSenha.Text);
            comboBoxEmpresa.DisplayMember = "nome_razao_social";
            comboBoxEmpresa.DataSource = dataTableEmpresa;
            if(dataTableEmpresa != null)            
            {
                btnSalvar.Enabled = true;
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int idEmpresa;
            var t = (DataRowView)comboBoxEmpresa.SelectedItem;
            idEmpresa = (int)t[0];
            Conexao.SalvarConfiguracaoBaseDados(textBoxIpServidor.Text, textBoxPorta.Text, textBoxBaseDados.Text, textBoxUsuario.Text, textBoxSenha.Text, idEmpresa);
            Close();
        }
    }
}
