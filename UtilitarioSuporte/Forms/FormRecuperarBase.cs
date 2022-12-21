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
    public partial class FormRecuperarBase : Form
    {
        public FormRecuperarBase()
        {
            InitializeComponent();
        }


        private void btnConectarBD_Click(object sender, EventArgs e)
        {
            bool retorno = Contexto.ConexaoBancoDados(tbxBdIP.Text, tbxBdPorta.Text, tbxBdUsuario.Text, tbxBdSenha.Text);
            if(retorno == true)
            {
                btnRecuperarBase.Enabled = true;
            }
        }

        private void btnRecuperarBase_Click(object sender, EventArgs e)
        {
            Contexto.RecuperarBaseDados(tbxBdIP.Text, tbxBdPorta.Text, tbxBdUsuario.Text, tbxBdSenha.Text, tbxCaminhoBaseDados.Text, tbxCaminhoPSQL.Text, tbxBdNomeBase.Text);
        }

        private void btnFolderPsql_Click(object sender, EventArgs e)
        {
            tbxCaminhoPSQL.Text = Funcoes.SelecionarPasta();
        }

        private void btnFolderCaminhoBase_Click(object sender, EventArgs e)
        {
            tbxCaminhoBaseDados.Text = Funcoes.SelecionarArquivo();
        }
    }
}
