namespace UtilitarioSuporte
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
            this.btnExterno = new FontAwesome.Sharp.IconButton();
            this.btnRecuperarBase = new FontAwesome.Sharp.IconButton();
            this.btnXml = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblSuporte = new System.Windows.Forms.Label();
            this.pictureHome = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnConexao = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnConexao);
            this.panelMenu.Controls.Add(this.btnExterno);
            this.panelMenu.Controls.Add(this.btnRecuperarBase);
            this.panelMenu.Controls.Add(this.btnXml);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // btnExterno
            // 
            this.btnExterno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExterno.FlatAppearance.BorderSize = 0;
            this.btnExterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExterno.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExterno.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnExterno.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExterno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExterno.IconSize = 32;
            this.btnExterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExterno.Location = new System.Drawing.Point(0, 240);
            this.btnExterno.Name = "btnExterno";
            this.btnExterno.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExterno.Size = new System.Drawing.Size(180, 60);
            this.btnExterno.TabIndex = 5;
            this.btnExterno.Text = "Externo";
            this.btnExterno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExterno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExterno.UseVisualStyleBackColor = true;
            this.btnExterno.Click += new System.EventHandler(this.btnExterno_Click);
            // 
            // btnRecuperarBase
            // 
            this.btnRecuperarBase.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btnRecuperarBase.Text = "Recuperar Base";
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
            this.pictureHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
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
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(620, 75);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Snow;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMinimize.IconSize = 12;
            this.btnMinimize.Location = new System.Drawing.Point(527, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 23);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Snow;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMaximize.IconSize = 12;
            this.btnMaximize.Location = new System.Drawing.Point(559, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(26, 23);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.Color.Snow;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnExit.IconSize = 12;
            this.btnExit.Location = new System.Drawing.Point(591, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(58, 33);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Iniciar";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(19, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(180, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(620, 9);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(180, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(620, 366);
            this.panelDesktop.TabIndex = 4;
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
            this.btnConexao.Location = new System.Drawing.Point(0, 300);
            this.btnConexao.Name = "btnConexao";
            this.btnConexao.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConexao.Size = new System.Drawing.Size(180, 60);
            this.btnConexao.TabIndex = 6;
            this.btnConexao.Text = "Conexao";
            this.btnConexao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConexao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConexao.UseVisualStyleBackColor = true;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMenuPrincipal";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnXml;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnExterno;
        private FontAwesome.Sharp.IconButton btnRecuperarBase;
        private FontAwesome.Sharp.IconPictureBox pictureHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Label lblSuporte;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnConexao;
    }
}

