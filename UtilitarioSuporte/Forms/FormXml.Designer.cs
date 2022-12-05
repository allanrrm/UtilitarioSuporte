﻿namespace UtilitarioSuporte.Forms
{
    partial class FormXml
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
            this.lblValorXml = new System.Windows.Forms.Label();
            this.lblValorAutorizadas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblContadorNotasXml = new System.Windows.Forms.Label();
            this.lblContadorCanceladas = new System.Windows.Forms.Label();
            this.lblContadorAutorizadas = new System.Windows.Forms.Label();
            this.lblNotasXml = new System.Windows.Forms.Label();
            this.lblCanceladas = new System.Windows.Forms.Label();
            this.lblAutorizadas = new System.Windows.Forms.Label();
            this.lblContadorNotas = new System.Windows.Forms.Label();
            this.lblNumeroNotas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSerie = new System.Windows.Forms.Label();
            this.dataGridViewSerie = new System.Windows.Forms.DataGridView();
            this.lblDivergente = new System.Windows.Forms.Label();
            this.lblSaltados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDivergente = new System.Windows.Forms.DataGridView();
            this.dataGridViewSaltados = new System.Windows.Forms.DataGridView();
            this.dataGridViewXml = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDivergente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaltados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXml)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblValorXml);
            this.panel1.Controls.Add(this.lblValorAutorizadas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblValorA);
            this.panel1.Controls.Add(this.lblContadorNotasXml);
            this.panel1.Controls.Add(this.lblContadorCanceladas);
            this.panel1.Controls.Add(this.lblContadorAutorizadas);
            this.panel1.Controls.Add(this.lblNotasXml);
            this.panel1.Controls.Add(this.lblCanceladas);
            this.panel1.Controls.Add(this.lblAutorizadas);
            this.panel1.Controls.Add(this.lblContadorNotas);
            this.panel1.Controls.Add(this.lblNumeroNotas);
            this.panel1.Location = new System.Drawing.Point(239, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblValorXml
            // 
            this.lblValorXml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorXml.AutoSize = true;
            this.lblValorXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorXml.Location = new System.Drawing.Point(628, 72);
            this.lblValorXml.Name = "lblValorXml";
            this.lblValorXml.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValorXml.Size = new System.Drawing.Size(11, 16);
            this.lblValorXml.TabIndex = 6;
            this.lblValorXml.Text = "-";
            this.lblValorXml.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValorAutorizadas
            // 
            this.lblValorAutorizadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorAutorizadas.AutoSize = true;
            this.lblValorAutorizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAutorizadas.Location = new System.Drawing.Point(628, 11);
            this.lblValorAutorizadas.Name = "lblValorAutorizadas";
            this.lblValorAutorizadas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValorAutorizadas.Size = new System.Drawing.Size(11, 16);
            this.lblValorAutorizadas.TabIndex = 5;
            this.lblValorAutorizadas.Text = "-";
            this.lblValorAutorizadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor XML(Autorizadas):";
            // 
            // lblValorA
            // 
            this.lblValorA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorA.AutoSize = true;
            this.lblValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorA.Location = new System.Drawing.Point(498, 11);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(124, 16);
            this.lblValorA.TabIndex = 2;
            this.lblValorA.Text = "Valor (Autorizadas):";
            // 
            // lblContadorNotasXml
            // 
            this.lblContadorNotasXml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContadorNotasXml.AutoSize = true;
            this.lblContadorNotasXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorNotasXml.Location = new System.Drawing.Point(241, 72);
            this.lblContadorNotasXml.Name = "lblContadorNotasXml";
            this.lblContadorNotasXml.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblContadorNotasXml.Size = new System.Drawing.Size(11, 16);
            this.lblContadorNotasXml.TabIndex = 2;
            this.lblContadorNotasXml.Text = "-";
            this.lblContadorNotasXml.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContadorCanceladas
            // 
            this.lblContadorCanceladas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContadorCanceladas.AutoSize = true;
            this.lblContadorCanceladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorCanceladas.Location = new System.Drawing.Point(241, 41);
            this.lblContadorCanceladas.Name = "lblContadorCanceladas";
            this.lblContadorCanceladas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblContadorCanceladas.Size = new System.Drawing.Size(11, 16);
            this.lblContadorCanceladas.TabIndex = 3;
            this.lblContadorCanceladas.Text = "-";
            this.lblContadorCanceladas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContadorAutorizadas
            // 
            this.lblContadorAutorizadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContadorAutorizadas.AutoSize = true;
            this.lblContadorAutorizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorAutorizadas.Location = new System.Drawing.Point(241, 11);
            this.lblContadorAutorizadas.Name = "lblContadorAutorizadas";
            this.lblContadorAutorizadas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblContadorAutorizadas.Size = new System.Drawing.Size(11, 16);
            this.lblContadorAutorizadas.TabIndex = 4;
            this.lblContadorAutorizadas.Text = "-";
            this.lblContadorAutorizadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNotasXml
            // 
            this.lblNotasXml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotasXml.AutoSize = true;
            this.lblNotasXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotasXml.Location = new System.Drawing.Point(131, 72);
            this.lblNotasXml.Name = "lblNotasXml";
            this.lblNotasXml.Size = new System.Drawing.Size(104, 16);
            this.lblNotasXml.TabIndex = 3;
            this.lblNotasXml.Text = "Notas com XML:";
            // 
            // lblCanceladas
            // 
            this.lblCanceladas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCanceladas.AutoSize = true;
            this.lblCanceladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanceladas.Location = new System.Drawing.Point(152, 42);
            this.lblCanceladas.Name = "lblCanceladas";
            this.lblCanceladas.Size = new System.Drawing.Size(83, 16);
            this.lblCanceladas.TabIndex = 2;
            this.lblCanceladas.Text = "Canceladas:";
            // 
            // lblAutorizadas
            // 
            this.lblAutorizadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAutorizadas.AutoSize = true;
            this.lblAutorizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorizadas.Location = new System.Drawing.Point(154, 11);
            this.lblAutorizadas.Name = "lblAutorizadas";
            this.lblAutorizadas.Size = new System.Drawing.Size(81, 16);
            this.lblAutorizadas.TabIndex = 1;
            this.lblAutorizadas.Text = "Autorizadas:";
            // 
            // lblContadorNotas
            // 
            this.lblContadorNotas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContadorNotas.AutoSize = true;
            this.lblContadorNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorNotas.Location = new System.Drawing.Point(60, 41);
            this.lblContadorNotas.Name = "lblContadorNotas";
            this.lblContadorNotas.Size = new System.Drawing.Size(15, 20);
            this.lblContadorNotas.TabIndex = 1;
            this.lblContadorNotas.Text = "-";
            // 
            // lblNumeroNotas
            // 
            this.lblNumeroNotas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumeroNotas.AutoSize = true;
            this.lblNumeroNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroNotas.Location = new System.Drawing.Point(12, 24);
            this.lblNumeroNotas.Name = "lblNumeroNotas";
            this.lblNumeroNotas.Size = new System.Drawing.Size(123, 17);
            this.lblNumeroNotas.TabIndex = 0;
            this.lblNumeroNotas.Text = "Numero de Notas:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSerie);
            this.panel2.Controls.Add(this.dataGridViewSerie);
            this.panel2.Controls.Add(this.lblDivergente);
            this.panel2.Controls.Add(this.lblSaltados);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridViewDivergente);
            this.panel2.Controls.Add(this.dataGridViewSaltados);
            this.panel2.Controls.Add(this.dataGridViewXml);
            this.panel2.Location = new System.Drawing.Point(12, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 501);
            this.panel2.TabIndex = 1;
            // 
            // lblSerie
            // 
            this.lblSerie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(16, 317);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(46, 20);
            this.lblSerie.TabIndex = 7;
            this.lblSerie.Text = "Serie";
            this.lblSerie.Visible = false;
            // 
            // dataGridViewSerie
            // 
            this.dataGridViewSerie.AllowUserToOrderColumns = true;
            this.dataGridViewSerie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSerie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSerie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSerie.Location = new System.Drawing.Point(18, 340);
            this.dataGridViewSerie.Name = "dataGridViewSerie";
            this.dataGridViewSerie.Size = new System.Drawing.Size(331, 136);
            this.dataGridViewSerie.TabIndex = 6;
            this.dataGridViewSerie.Visible = false;
            // 
            // lblDivergente
            // 
            this.lblDivergente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivergente.AutoSize = true;
            this.lblDivergente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivergente.Location = new System.Drawing.Point(610, 16);
            this.lblDivergente.Name = "lblDivergente";
            this.lblDivergente.Size = new System.Drawing.Size(117, 20);
            this.lblDivergente.TabIndex = 5;
            this.lblDivergente.Text = "Xml Divergente";
            this.lblDivergente.Visible = false;
            // 
            // lblSaltados
            // 
            this.lblSaltados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaltados.AutoSize = true;
            this.lblSaltados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaltados.Location = new System.Drawing.Point(372, 16);
            this.lblSaltados.Name = "lblSaltados";
            this.lblSaltados.Size = new System.Drawing.Size(140, 20);
            this.lblSaltados.TabIndex = 4;
            this.lblSaltados.Text = "Numeros Saltados";
            this.lblSaltados.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notas Detalhadas";
            // 
            // dataGridViewDivergente
            // 
            this.dataGridViewDivergente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDivergente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDivergente.Location = new System.Drawing.Point(614, 39);
            this.dataGridViewDivergente.Name = "dataGridViewDivergente";
            this.dataGridViewDivergente.Size = new System.Drawing.Size(286, 254);
            this.dataGridViewDivergente.TabIndex = 2;
            this.dataGridViewDivergente.Visible = false;
            // 
            // dataGridViewSaltados
            // 
            this.dataGridViewSaltados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSaltados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaltados.Location = new System.Drawing.Point(376, 39);
            this.dataGridViewSaltados.Name = "dataGridViewSaltados";
            this.dataGridViewSaltados.Size = new System.Drawing.Size(213, 254);
            this.dataGridViewSaltados.TabIndex = 1;
            this.dataGridViewSaltados.Visible = false;
            // 
            // dataGridViewXml
            // 
            this.dataGridViewXml.AllowUserToOrderColumns = true;
            this.dataGridViewXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewXml.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewXml.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewXml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXml.Location = new System.Drawing.Point(18, 39);
            this.dataGridViewXml.Name = "dataGridViewXml";
            this.dataGridViewXml.Size = new System.Drawing.Size(331, 254);
            this.dataGridViewXml.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnFiltrar);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxAno);
            this.panel3.Controls.Add(this.comboBoxMes);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 100);
            this.panel3.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnFiltrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFiltrar.Location = new System.Drawing.Point(0, 75);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(219, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ano";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mês";
            // 
            // textBoxAno
            // 
            this.textBoxAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAno.Location = new System.Drawing.Point(119, 37);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(83, 20);
            this.textBoxAno.TabIndex = 1;
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBoxMes.Location = new System.Drawing.Point(18, 37);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(88, 21);
            this.comboBoxMes.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 669);
            this.panel4.TabIndex = 4;
            // 
            // FormXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 669);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "FormXml";
            this.Text = "DadosXml";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDivergente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaltados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXml)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorAutorizadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblContadorNotasXml;
        private System.Windows.Forms.Label lblContadorCanceladas;
        private System.Windows.Forms.Label lblContadorAutorizadas;
        private System.Windows.Forms.Label lblNotasXml;
        private System.Windows.Forms.Label lblCanceladas;
        private System.Windows.Forms.Label lblAutorizadas;
        private System.Windows.Forms.Label lblContadorNotas;
        private System.Windows.Forms.Label lblNumeroNotas;
        private System.Windows.Forms.Label lblValorXml;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDivergente;
        private System.Windows.Forms.Label lblSaltados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDivergente;
        private System.Windows.Forms.DataGridView dataGridViewSaltados;
        private System.Windows.Forms.DataGridView dataGridViewXml;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.DataGridView dataGridViewSerie;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFiltrar;
    }
}