using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitarioSuporte.Recursos
{
    internal class MessageBoxPersonalizada : Form
    {
        private Label lblMensagemPrincipal;
        private Button btnConfirmar;
        private Label lblTitulo;

        public MessageBoxPersonalizada()
        {
            InitializeComponent();
        }

        public MessageBoxPersonalizada(string mensagemPrincipal, string titulo, string botao)
        {
            InitializeComponent();

            this.lblTitulo.Text = titulo;
            this.lblMensagemPrincipal.Text = mensagemPrincipal;
            this.btnConfirmar.Text = botao;
        }


        private void InitializeComponent()
        {
            this.lblMensagemPrincipal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensagemPrincipal
            // 
            this.lblMensagemPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagemPrincipal.AutoSize = true;
            this.lblMensagemPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemPrincipal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMensagemPrincipal.Location = new System.Drawing.Point(136, 64);
            this.lblMensagemPrincipal.Name = "lblMensagemPrincipal";
            this.lblMensagemPrincipal.Size = new System.Drawing.Size(41, 15);
            this.lblMensagemPrincipal.TabIndex = 0;
            this.lblMensagemPrincipal.Text = "label1";
            this.lblMensagemPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(119, 111);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "button1";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 17);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "label1";
            // 
            // MessageBoxPersonalizada
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(325, 146);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblMensagemPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MessageBoxPersonalizada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        public static class CustomMessageBox
        {
            public static void Show(string title, string description, string botao)
            {
                // using construct ensures the resources are freed when form is closed
                using (var form = new MessageBoxPersonalizada(title, description, botao))
                {
                    form.ShowDialog();
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
