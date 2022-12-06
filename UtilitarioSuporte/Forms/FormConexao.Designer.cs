namespace UtilitarioSuporte
{
    partial class FormConexao
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxPorta = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPorta = new System.Windows.Forms.Label();
            this.textBoxIpServidor = new System.Windows.Forms.TextBox();
            this.lblBaseDados = new System.Windows.Forms.Label();
            this.lbliP = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxBaseDados = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new FontAwesome.Sharp.IconButton();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.panelBotoesConexao = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelBotoesConexao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 663);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.comboBoxEmpresa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxSenha);
            this.panel2.Controls.Add(this.textBoxPorta);
            this.panel2.Controls.Add(this.lblEmpresa);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.lblPorta);
            this.panel2.Controls.Add(this.textBoxIpServidor);
            this.panel2.Controls.Add(this.lblBaseDados);
            this.panel2.Controls.Add(this.lbliP);
            this.panel2.Controls.Add(this.lblSenha);
            this.panel2.Controls.Add(this.textBoxUsuario);
            this.panel2.Controls.Add(this.textBoxBaseDados);
            this.panel2.Location = new System.Drawing.Point(1, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 202);
            this.panel2.TabIndex = 26;
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(276, 139);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(185, 21);
            this.comboBoxEmpresa.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dados do Servidor:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSenha.Location = new System.Drawing.Point(145, 139);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(100, 20);
            this.textBoxSenha.TabIndex = 20;
            this.textBoxSenha.Text = "autocom2017@";
            this.textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxPorta
            // 
            this.textBoxPorta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPorta.Location = new System.Drawing.Point(273, 86);
            this.textBoxPorta.Name = "textBoxPorta";
            this.textBoxPorta.Size = new System.Drawing.Size(100, 20);
            this.textBoxPorta.TabIndex = 18;
            this.textBoxPorta.Text = "5432";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmpresa.Location = new System.Drawing.Point(270, 119);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(64, 17);
            this.lblEmpresa.TabIndex = 24;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuario.Location = new System.Drawing.Point(10, 119);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPorta
            // 
            this.lblPorta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPorta.AutoSize = true;
            this.lblPorta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPorta.Location = new System.Drawing.Point(270, 66);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(42, 17);
            this.lblPorta.TabIndex = 17;
            this.lblPorta.Text = "Porta";
            // 
            // textBoxIpServidor
            // 
            this.textBoxIpServidor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxIpServidor.Location = new System.Drawing.Point(13, 86);
            this.textBoxIpServidor.Name = "textBoxIpServidor";
            this.textBoxIpServidor.Size = new System.Drawing.Size(100, 20);
            this.textBoxIpServidor.TabIndex = 12;
            this.textBoxIpServidor.Text = "127.0.0.1";
            // 
            // lblBaseDados
            // 
            this.lblBaseDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaseDados.AutoSize = true;
            this.lblBaseDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblBaseDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaseDados.Location = new System.Drawing.Point(142, 66);
            this.lblBaseDados.Name = "lblBaseDados";
            this.lblBaseDados.Size = new System.Drawing.Size(105, 17);
            this.lblBaseDados.TabIndex = 13;
            this.lblBaseDados.Text = "Base de Dados";
            // 
            // lbliP
            // 
            this.lbliP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbliP.AutoSize = true;
            this.lbliP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lbliP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbliP.Location = new System.Drawing.Point(10, 66);
            this.lbliP.Name = "lbliP";
            this.lbliP.Size = new System.Drawing.Size(96, 17);
            this.lbliP.TabIndex = 11;
            this.lbliP.Text = "Ip do Servidor";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSenha.Location = new System.Drawing.Point(142, 119);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 19;
            this.lblSenha.Text = "Senha";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxUsuario.Location = new System.Drawing.Point(13, 139);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 16;
            this.textBoxUsuario.Text = "postgres";
            // 
            // textBoxBaseDados
            // 
            this.textBoxBaseDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBaseDados.Location = new System.Drawing.Point(145, 85);
            this.textBoxBaseDados.Name = "textBoxBaseDados";
            this.textBoxBaseDados.Size = new System.Drawing.Size(100, 20);
            this.textBoxBaseDados.TabIndex = 14;
            this.textBoxBaseDados.Text = "esistemloja";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 46);
            this.panel3.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Configurações";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnConectar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConectar.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnConectar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConectar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConectar.IconSize = 32;
            this.btnConectar.Location = new System.Drawing.Point(0, 0);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(482, 40);
            this.btnConectar.TabIndex = 25;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSalvar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSalvar.IconSize = 32;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(0, 40);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(482, 40);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panelBotoesConexao
            // 
            this.panelBotoesConexao.BackColor = System.Drawing.Color.Gray;
            this.panelBotoesConexao.Controls.Add(this.btnConectar);
            this.panelBotoesConexao.Controls.Add(this.btnSalvar);
            this.panelBotoesConexao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoesConexao.Location = new System.Drawing.Point(0, 589);
            this.panelBotoesConexao.Name = "panelBotoesConexao";
            this.panelBotoesConexao.Size = new System.Drawing.Size(482, 80);
            this.panelBotoesConexao.TabIndex = 26;
            // 
            // FormConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 669);
            this.Controls.Add(this.panelBotoesConexao);
            this.Controls.Add(this.panel1);
            this.Name = "FormConexao";
            this.Text = "Conexão";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelBotoesConexao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnConectar;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private System.Windows.Forms.Panel panelBotoesConexao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxPorta;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.TextBox textBoxIpServidor;
        private System.Windows.Forms.Label lblBaseDados;
        private System.Windows.Forms.Label lbliP;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxBaseDados;
    }
}