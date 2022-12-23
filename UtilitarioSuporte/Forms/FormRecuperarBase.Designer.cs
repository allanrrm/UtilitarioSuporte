namespace UtilitarioSuporte.Forms
{
    partial class FormRecuperarBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecuperarBase = new System.Windows.Forms.Button();
            this.tbxCaminhoBaseDados = new System.Windows.Forms.TextBox();
            this.tbxBdNomeBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLocalBD_Retaguarda = new System.Windows.Forms.Label();
            this.tbxCaminhoPSQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDadosServidor = new System.Windows.Forms.Panel();
            this.btnConectarBD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblUsuarioBD_Retaguarda = new System.Windows.Forms.Label();
            this.lblSenhaBD_Retaguarda = new System.Windows.Forms.Label();
            this.tbxBdSenha = new System.Windows.Forms.TextBox();
            this.tbxBdIP = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbxBdUsuario = new System.Windows.Forms.TextBox();
            this.tbxBdPorta = new System.Windows.Forms.TextBox();
            this.btnFolderPsql = new FontAwesome.Sharp.IconButton();
            this.btnFolderCaminhoBase = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDadosServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelDadosServidor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnFolderCaminhoBase);
            this.panel3.Controls.Add(this.btnFolderPsql);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnRecuperarBase);
            this.panel3.Controls.Add(this.tbxCaminhoBaseDados);
            this.panel3.Controls.Add(this.tbxBdNomeBase);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblLocalBD_Retaguarda);
            this.panel3.Controls.Add(this.tbxCaminhoPSQL);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(13, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 252);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dados do Postgres";
            // 
            // btnRecuperarBase
            // 
            this.btnRecuperarBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecuperarBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnRecuperarBase.Enabled = false;
            this.btnRecuperarBase.FlatAppearance.BorderSize = 0;
            this.btnRecuperarBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarBase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRecuperarBase.Location = new System.Drawing.Point(3, 224);
            this.btnRecuperarBase.Name = "btnRecuperarBase";
            this.btnRecuperarBase.Size = new System.Drawing.Size(768, 23);
            this.btnRecuperarBase.TabIndex = 20;
            this.btnRecuperarBase.Text = "Conectar";
            this.btnRecuperarBase.UseVisualStyleBackColor = false;
            this.btnRecuperarBase.Click += new System.EventHandler(this.btnRecuperarBase_Click);
            // 
            // tbxCaminhoBaseDados
            // 
            this.tbxCaminhoBaseDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCaminhoBaseDados.Enabled = false;
            this.tbxCaminhoBaseDados.Location = new System.Drawing.Point(16, 173);
            this.tbxCaminhoBaseDados.Name = "tbxCaminhoBaseDados";
            this.tbxCaminhoBaseDados.Size = new System.Drawing.Size(717, 20);
            this.tbxCaminhoBaseDados.TabIndex = 18;
            // 
            // tbxBdNomeBase
            // 
            this.tbxBdNomeBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxBdNomeBase.Location = new System.Drawing.Point(16, 69);
            this.tbxBdNomeBase.Name = "tbxBdNomeBase";
            this.tbxBdNomeBase.Size = new System.Drawing.Size(126, 20);
            this.tbxBdNomeBase.TabIndex = 14;
            this.tbxBdNomeBase.Text = "esistemloja";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Caminho da Base de Dados";
            // 
            // lblLocalBD_Retaguarda
            // 
            this.lblLocalBD_Retaguarda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocalBD_Retaguarda.AutoSize = true;
            this.lblLocalBD_Retaguarda.Location = new System.Drawing.Point(13, 51);
            this.lblLocalBD_Retaguarda.Name = "lblLocalBD_Retaguarda";
            this.lblLocalBD_Retaguarda.Size = new System.Drawing.Size(129, 13);
            this.lblLocalBD_Retaguarda.TabIndex = 13;
            this.lblLocalBD_Retaguarda.Text = "Nome da Base de Dados:";
            // 
            // tbxCaminhoPSQL
            // 
            this.tbxCaminhoPSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCaminhoPSQL.Enabled = false;
            this.tbxCaminhoPSQL.Location = new System.Drawing.Point(16, 120);
            this.tbxCaminhoPSQL.Name = "tbxCaminhoPSQL";
            this.tbxCaminhoPSQL.Size = new System.Drawing.Size(717, 20);
            this.tbxCaminhoPSQL.TabIndex = 16;
            this.tbxCaminhoPSQL.Text = "C:\\Program Files (x86)\\PostgreSQL\\9.5\\bin";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Caminho do Psql";
            // 
            // panelDadosServidor
            // 
            this.panelDadosServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDadosServidor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDadosServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDadosServidor.Controls.Add(this.btnConectarBD);
            this.panelDadosServidor.Controls.Add(this.label1);
            this.panelDadosServidor.Controls.Add(this.label24);
            this.panelDadosServidor.Controls.Add(this.lblUsuarioBD_Retaguarda);
            this.panelDadosServidor.Controls.Add(this.lblSenhaBD_Retaguarda);
            this.panelDadosServidor.Controls.Add(this.tbxBdSenha);
            this.panelDadosServidor.Controls.Add(this.tbxBdIP);
            this.panelDadosServidor.Controls.Add(this.label23);
            this.panelDadosServidor.Controls.Add(this.tbxBdUsuario);
            this.panelDadosServidor.Controls.Add(this.tbxBdPorta);
            this.panelDadosServidor.Location = new System.Drawing.Point(13, 12);
            this.panelDadosServidor.Name = "panelDadosServidor";
            this.panelDadosServidor.Size = new System.Drawing.Size(776, 150);
            this.panelDadosServidor.TabIndex = 0;
            // 
            // btnConectarBD
            // 
            this.btnConectarBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConectarBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnConectarBD.FlatAppearance.BorderSize = 0;
            this.btnConectarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectarBD.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConectarBD.Location = new System.Drawing.Point(3, 122);
            this.btnConectarBD.Name = "btnConectarBD";
            this.btnConectarBD.Size = new System.Drawing.Size(768, 23);
            this.btnConectarBD.TabIndex = 19;
            this.btnConectarBD.Text = "Conectar";
            this.btnConectarBD.UseVisualStyleBackColor = false;
            this.btnConectarBD.Click += new System.EventHandler(this.btnConectarBD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dados do Servidor";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "IP do Servidor:";
            // 
            // lblUsuarioBD_Retaguarda
            // 
            this.lblUsuarioBD_Retaguarda.AutoSize = true;
            this.lblUsuarioBD_Retaguarda.Location = new System.Drawing.Point(219, 47);
            this.lblUsuarioBD_Retaguarda.Name = "lblUsuarioBD_Retaguarda";
            this.lblUsuarioBD_Retaguarda.Size = new System.Drawing.Size(46, 13);
            this.lblUsuarioBD_Retaguarda.TabIndex = 15;
            this.lblUsuarioBD_Retaguarda.Text = "Usuário:";
            // 
            // lblSenhaBD_Retaguarda
            // 
            this.lblSenhaBD_Retaguarda.AutoSize = true;
            this.lblSenhaBD_Retaguarda.Location = new System.Drawing.Point(320, 47);
            this.lblSenhaBD_Retaguarda.Name = "lblSenhaBD_Retaguarda";
            this.lblSenhaBD_Retaguarda.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaBD_Retaguarda.TabIndex = 17;
            this.lblSenhaBD_Retaguarda.Text = "Senha:";
            // 
            // tbxBdSenha
            // 
            this.tbxBdSenha.Location = new System.Drawing.Point(323, 63);
            this.tbxBdSenha.Name = "tbxBdSenha";
            this.tbxBdSenha.PasswordChar = '#';
            this.tbxBdSenha.Size = new System.Drawing.Size(93, 20);
            this.tbxBdSenha.TabIndex = 18;
            this.tbxBdSenha.Text = "autocom2017@";
            // 
            // tbxBdIP
            // 
            this.tbxBdIP.Location = new System.Drawing.Point(15, 63);
            this.tbxBdIP.Name = "tbxBdIP";
            this.tbxBdIP.Size = new System.Drawing.Size(80, 20);
            this.tbxBdIP.TabIndex = 12;
            this.tbxBdIP.Text = "127.0.0.1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(130, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 13;
            this.label23.Text = "Porta";
            // 
            // tbxBdUsuario
            // 
            this.tbxBdUsuario.Location = new System.Drawing.Point(222, 63);
            this.tbxBdUsuario.Name = "tbxBdUsuario";
            this.tbxBdUsuario.Size = new System.Drawing.Size(63, 20);
            this.tbxBdUsuario.TabIndex = 16;
            this.tbxBdUsuario.Text = "postgres";
            // 
            // tbxBdPorta
            // 
            this.tbxBdPorta.Location = new System.Drawing.Point(133, 63);
            this.tbxBdPorta.Name = "tbxBdPorta";
            this.tbxBdPorta.Size = new System.Drawing.Size(48, 20);
            this.tbxBdPorta.TabIndex = 14;
            this.tbxBdPorta.Text = "5432";
            // 
            // btnFolderPsql
            // 
            this.btnFolderPsql.BackColor = System.Drawing.SystemColors.Window;
            this.btnFolderPsql.Enabled = false;
            this.btnFolderPsql.FlatAppearance.BorderSize = 0;
            this.btnFolderPsql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderPsql.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnFolderPsql.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnFolderPsql.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFolderPsql.IconSize = 24;
            this.btnFolderPsql.Location = new System.Drawing.Point(739, 118);
            this.btnFolderPsql.Name = "btnFolderPsql";
            this.btnFolderPsql.Size = new System.Drawing.Size(31, 23);
            this.btnFolderPsql.TabIndex = 22;
            this.btnFolderPsql.UseVisualStyleBackColor = false;
            this.btnFolderPsql.Click += new System.EventHandler(this.btnFolderPsql_Click);
            // 
            // btnFolderCaminhoBase
            // 
            this.btnFolderCaminhoBase.Enabled = false;
            this.btnFolderCaminhoBase.FlatAppearance.BorderSize = 0;
            this.btnFolderCaminhoBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderCaminhoBase.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnFolderCaminhoBase.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnFolderCaminhoBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFolderCaminhoBase.IconSize = 24;
            this.btnFolderCaminhoBase.Location = new System.Drawing.Point(739, 171);
            this.btnFolderCaminhoBase.Name = "btnFolderCaminhoBase";
            this.btnFolderCaminhoBase.Size = new System.Drawing.Size(31, 23);
            this.btnFolderCaminhoBase.TabIndex = 23;
            this.btnFolderCaminhoBase.UseVisualStyleBackColor = true;
            this.btnFolderCaminhoBase.Click += new System.EventHandler(this.btnFolderCaminhoBase_Click);
            // 
            // FormRecuperarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormRecuperarBase";
            this.Text = "FormRecuperarBase";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelDadosServidor.ResumeLayout(false);
            this.panelDadosServidor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRecuperarBase;
        private System.Windows.Forms.TextBox tbxCaminhoBaseDados;
        private System.Windows.Forms.TextBox tbxBdNomeBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLocalBD_Retaguarda;
        private System.Windows.Forms.TextBox tbxCaminhoPSQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDadosServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblUsuarioBD_Retaguarda;
        private System.Windows.Forms.Label lblSenhaBD_Retaguarda;
        private System.Windows.Forms.Button btnConectarBD;
        private System.Windows.Forms.TextBox tbxBdSenha;
        private System.Windows.Forms.TextBox tbxBdIP;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbxBdUsuario;
        private System.Windows.Forms.TextBox tbxBdPorta;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnFolderCaminhoBase;
        private FontAwesome.Sharp.IconButton btnFolderPsql;
    }
}