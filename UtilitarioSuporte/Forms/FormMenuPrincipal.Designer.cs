﻿namespace UtilitarioSuporte
{
    partial class FormMenuPrincipal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.btnConexao = new FontAwesome.Sharp.IconButton();
            this.btnExterno = new FontAwesome.Sharp.IconButton();
            this.btnRestaurar = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuXml = new System.Windows.Forms.Panel();
            this.btnNFCe = new FontAwesome.Sharp.IconButton();
            this.btnSaida = new FontAwesome.Sharp.IconButton();
            this.btnEntrada = new FontAwesome.Sharp.IconButton();
            this.btnRecuperarBase = new FontAwesome.Sharp.IconButton();
            this.btnXml = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblSuporte = new System.Windows.Forms.Label();
            this.pictureHome = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelSubMenuXml.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelMenu.Controls.Add(this.btnFechar);
            this.panelMenu.Controls.Add(this.btnConexao);
            this.panelMenu.Controls.Add(this.btnExterno);
            this.panelMenu.Controls.Add(this.btnRestaurar);
            this.panelMenu.Controls.Add(this.panelSubMenuXml);
            this.panelMenu.Controls.Add(this.btnRecuperarBase);
            this.panelMenu.Controls.Add(this.btnXml);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 578);
            this.panelMenu.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnFechar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechar.IconSize = 32;
            this.btnFechar.Location = new System.Drawing.Point(0, 533);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(180, 45);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Sair";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            this.btnFechar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFechar_MouseMove);
            // 
            // btnConexao
            // 
            this.btnConexao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConexao.FlatAppearance.BorderSize = 0;
            this.btnConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConexao.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnConexao.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConexao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConexao.IconSize = 32;
            this.btnConexao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConexao.Location = new System.Drawing.Point(0, 424);
            this.btnConexao.Name = "btnConexao";
            this.btnConexao.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConexao.Size = new System.Drawing.Size(180, 60);
            this.btnConexao.TabIndex = 7;
            this.btnConexao.Text = "Conexao";
            this.btnConexao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConexao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConexao.UseVisualStyleBackColor = true;
            this.btnConexao.Click += new System.EventHandler(this.btnConexao_Click);
            // 
            // btnExterno
            // 
            this.btnExterno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExterno.FlatAppearance.BorderSize = 0;
            this.btnExterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExterno.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExterno.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowRight;
            this.btnExterno.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExterno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExterno.IconSize = 32;
            this.btnExterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExterno.Location = new System.Drawing.Point(0, 364);
            this.btnExterno.Name = "btnExterno";
            this.btnExterno.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExterno.Size = new System.Drawing.Size(180, 60);
            this.btnExterno.TabIndex = 6;
            this.btnExterno.Text = "Externo";
            this.btnExterno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExterno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExterno.UseVisualStyleBackColor = true;
            this.btnExterno.Click += new System.EventHandler(this.btnExterno_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.btnRestaurar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaurar.IconSize = 32;
            this.btnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurar.Location = new System.Drawing.Point(0, 304);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRestaurar.Size = new System.Drawing.Size(180, 60);
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.Text = "Restaurar Base";
            this.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRecuperarBase_Click);
            // 
            // panelSubMenuXml
            // 
            this.panelSubMenuXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuXml.Controls.Add(this.btnNFCe);
            this.panelSubMenuXml.Controls.Add(this.btnSaida);
            this.panelSubMenuXml.Controls.Add(this.btnEntrada);
            this.panelSubMenuXml.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuXml.Location = new System.Drawing.Point(0, 180);
            this.panelSubMenuXml.Name = "panelSubMenuXml";
            this.panelSubMenuXml.Size = new System.Drawing.Size(180, 124);
            this.panelSubMenuXml.TabIndex = 4;
            // 
            // btnNFCe
            // 
            this.btnNFCe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNFCe.FlatAppearance.BorderSize = 0;
            this.btnNFCe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNFCe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNFCe.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnNFCe.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNFCe.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnNFCe.IconSize = 16;
            this.btnNFCe.Location = new System.Drawing.Point(0, 80);
            this.btnNFCe.Name = "btnNFCe";
            this.btnNFCe.Size = new System.Drawing.Size(180, 40);
            this.btnNFCe.TabIndex = 2;
            this.btnNFCe.Text = "NFC-e";
            this.btnNFCe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNFCe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNFCe.UseVisualStyleBackColor = true;
            // 
            // btnSaida
            // 
            this.btnSaida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaida.FlatAppearance.BorderSize = 0;
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSaida.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnSaida.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSaida.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSaida.IconSize = 16;
            this.btnSaida.Location = new System.Drawing.Point(0, 40);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnSaida.Size = new System.Drawing.Size(180, 40);
            this.btnSaida.TabIndex = 1;
            this.btnSaida.Text = "NF-e Saída";
            this.btnSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaida.UseVisualStyleBackColor = true;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntrada.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnEntrada.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEntrada.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEntrada.IconSize = 16;
            this.btnEntrada.Location = new System.Drawing.Point(0, 0);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEntrada.Size = new System.Drawing.Size(180, 40);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "NF-e Entrada";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnRecuperarBase
            // 
            this.btnRecuperarBase.AutoSize = true;
            this.btnRecuperarBase.FlatAppearance.BorderSize = 0;
            this.btnRecuperarBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarBase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRecuperarBase.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.btnRecuperarBase.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRecuperarBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecuperarBase.IconSize = 32;
            this.btnRecuperarBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecuperarBase.Location = new System.Drawing.Point(0, 180);
            this.btnRecuperarBase.Name = "btnRecuperarBase";
            this.btnRecuperarBase.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRecuperarBase.Size = new System.Drawing.Size(180, 60);
            this.btnRecuperarBase.TabIndex = 4;
            this.btnRecuperarBase.Text = "Restaurar Base";
            this.btnRecuperarBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecuperarBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecuperarBase.UseVisualStyleBackColor = true;
            this.btnRecuperarBase.Click += new System.EventHandler(this.btnRecuperarBase_Click);
            // 
            // btnXml
            // 
            this.btnXml.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXml.FlatAppearance.BorderSize = 0;
            this.btnXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXml.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXml.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnXml.IconColor = System.Drawing.Color.Gainsboro;
            this.btnXml.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXml.IconSize = 32;
            this.btnXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXml.Location = new System.Drawing.Point(0, 120);
            this.btnXml.Name = "btnXml";
            this.btnXml.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnXml.Size = new System.Drawing.Size(180, 60);
            this.btnXml.TabIndex = 3;
            this.btnXml.Text = "XML";
            this.btnXml.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXml.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblSuporte);
            this.panelLogo.Controls.Add(this.pictureHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 120);
            this.panelLogo.TabIndex = 2;
            // 
            // lblSuporte
            // 
            this.lblSuporte.AutoSize = true;
            this.lblSuporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuporte.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSuporte.Location = new System.Drawing.Point(12, 78);
            this.lblSuporte.Name = "lblSuporte";
            this.lblSuporte.Size = new System.Drawing.Size(140, 20);
            this.lblSuporte.TabIndex = 1;
            this.lblSuporte.Text = "Suporte Técnico";
            // 
            // pictureHome
            // 
            this.pictureHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pictureHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.pictureHome.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.pictureHome.IconColor = System.Drawing.Color.Gainsboro;
            this.pictureHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureHome.IconSize = 49;
            this.pictureHome.Location = new System.Drawing.Point(57, 26);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(49, 49);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureHome.TabIndex = 0;
            this.pictureHome.TabStop = false;
            this.pictureHome.Click += new System.EventHandler(this.pictureHome_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelShadow.Location = new System.Drawing.Point(0, 98);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1054, 16);
            this.panelShadow.TabIndex = 3;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.panelShadow);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1054, 98);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(65, 36);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(45, 17);
            this.lblTitleChildForm.TabIndex = 4;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.iconCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 32;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 26);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(35, 37);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(180, 98);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1054, 480);
            this.panelDesktop.TabIndex = 6;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1234, 578);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelSubMenuXml.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnXml;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconPictureBox pictureHome;
        private System.Windows.Forms.Label lblSuporte;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelSubMenuXml;
        private FontAwesome.Sharp.IconButton btnNFCe;
        private FontAwesome.Sharp.IconButton btnSaida;
        private FontAwesome.Sharp.IconButton btnEntrada;
        private FontAwesome.Sharp.IconButton btnRecuperarBase;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnFechar;
        private FontAwesome.Sharp.IconButton btnConexao;
        private FontAwesome.Sharp.IconButton btnExterno;
        private FontAwesome.Sharp.IconButton btnRestaurar;
        private System.Windows.Forms.Panel panelDesktop;
    }
}
