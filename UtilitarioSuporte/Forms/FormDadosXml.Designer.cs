namespace UtilitarioSuporte.Forms
{
    partial class FormDadosXml
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
            this.lblContadorSaltada = new System.Windows.Forms.Label();
            this.lblContadorCanceladas = new System.Windows.Forms.Label();
            this.lblContadorAutorizadas = new System.Windows.Forms.Label();
            this.lblSaltadas = new System.Windows.Forms.Label();
            this.lblCanceladas = new System.Windows.Forms.Label();
            this.lblAutorizadas = new System.Windows.Forms.Label();
            this.lblContadorNotas = new System.Windows.Forms.Label();
            this.lblNumeroNotas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExtrair = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblValorXml);
            this.panel1.Controls.Add(this.lblValorAutorizadas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblValorA);
            this.panel1.Controls.Add(this.lblContadorSaltada);
            this.panel1.Controls.Add(this.lblContadorCanceladas);
            this.panel1.Controls.Add(this.lblContadorAutorizadas);
            this.panel1.Controls.Add(this.lblSaltadas);
            this.panel1.Controls.Add(this.lblCanceladas);
            this.panel1.Controls.Add(this.lblAutorizadas);
            this.panel1.Controls.Add(this.lblContadorNotas);
            this.panel1.Controls.Add(this.lblNumeroNotas);
            this.panel1.Location = new System.Drawing.Point(239, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblValorXml
            // 
            this.lblValorXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorXml.AutoSize = true;
            this.lblValorXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorXml.Location = new System.Drawing.Point(650, 62);
            this.lblValorXml.Name = "lblValorXml";
            this.lblValorXml.Size = new System.Drawing.Size(44, 16);
            this.lblValorXml.TabIndex = 6;
            this.lblValorXml.Text = "label1";
            // 
            // lblValorAutorizadas
            // 
            this.lblValorAutorizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorAutorizadas.AutoSize = true;
            this.lblValorAutorizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAutorizadas.Location = new System.Drawing.Point(650, 24);
            this.lblValorAutorizadas.Name = "lblValorAutorizadas";
            this.lblValorAutorizadas.Size = new System.Drawing.Size(44, 16);
            this.lblValorAutorizadas.TabIndex = 5;
            this.lblValorAutorizadas.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor XML(Somente Autorizadas):";
            // 
            // lblValorA
            // 
            this.lblValorA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorA.AutoSize = true;
            this.lblValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorA.Location = new System.Drawing.Point(463, 24);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(181, 16);
            this.lblValorA.TabIndex = 2;
            this.lblValorA.Text = "Valor (Somente Autorizadas):";
            // 
            // lblContadorSaltada
            // 
            this.lblContadorSaltada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContadorSaltada.AutoSize = true;
            this.lblContadorSaltada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorSaltada.Location = new System.Drawing.Point(295, 72);
            this.lblContadorSaltada.Name = "lblContadorSaltada";
            this.lblContadorSaltada.Size = new System.Drawing.Size(44, 16);
            this.lblContadorSaltada.TabIndex = 2;
            this.lblContadorSaltada.Text = "label1";
            // 
            // lblContadorCanceladas
            // 
            this.lblContadorCanceladas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContadorCanceladas.AutoSize = true;
            this.lblContadorCanceladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorCanceladas.Location = new System.Drawing.Point(295, 42);
            this.lblContadorCanceladas.Name = "lblContadorCanceladas";
            this.lblContadorCanceladas.Size = new System.Drawing.Size(44, 16);
            this.lblContadorCanceladas.TabIndex = 3;
            this.lblContadorCanceladas.Text = "label1";
            // 
            // lblContadorAutorizadas
            // 
            this.lblContadorAutorizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContadorAutorizadas.AutoSize = true;
            this.lblContadorAutorizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorAutorizadas.Location = new System.Drawing.Point(295, 10);
            this.lblContadorAutorizadas.Name = "lblContadorAutorizadas";
            this.lblContadorAutorizadas.Size = new System.Drawing.Size(44, 16);
            this.lblContadorAutorizadas.TabIndex = 4;
            this.lblContadorAutorizadas.Text = "label1";
            // 
            // lblSaltadas
            // 
            this.lblSaltadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaltadas.AutoSize = true;
            this.lblSaltadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaltadas.Location = new System.Drawing.Point(156, 72);
            this.lblSaltadas.Name = "lblSaltadas";
            this.lblSaltadas.Size = new System.Drawing.Size(131, 16);
            this.lblSaltadas.TabIndex = 3;
            this.lblSaltadas.Text = "Numeração Saltada:";
            // 
            // lblCanceladas
            // 
            this.lblCanceladas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCanceladas.AutoSize = true;
            this.lblCanceladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanceladas.Location = new System.Drawing.Point(206, 42);
            this.lblCanceladas.Name = "lblCanceladas";
            this.lblCanceladas.Size = new System.Drawing.Size(83, 16);
            this.lblCanceladas.TabIndex = 2;
            this.lblCanceladas.Text = "Canceladas:";
            // 
            // lblAutorizadas
            // 
            this.lblAutorizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutorizadas.AutoSize = true;
            this.lblAutorizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorizadas.Location = new System.Drawing.Point(206, 11);
            this.lblAutorizadas.Name = "lblAutorizadas";
            this.lblAutorizadas.Size = new System.Drawing.Size(81, 16);
            this.lblAutorizadas.TabIndex = 1;
            this.lblAutorizadas.Text = "Autorizadas:";
            // 
            // lblContadorNotas
            // 
            this.lblContadorNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContadorNotas.AutoSize = true;
            this.lblContadorNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorNotas.Location = new System.Drawing.Point(40, 49);
            this.lblContadorNotas.Name = "lblContadorNotas";
            this.lblContadorNotas.Size = new System.Drawing.Size(51, 20);
            this.lblContadorNotas.TabIndex = 1;
            this.lblContadorNotas.Text = "label1";
            // 
            // lblNumeroNotas
            // 
            this.lblNumeroNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroNotas.AutoSize = true;
            this.lblNumeroNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroNotas.Location = new System.Drawing.Point(7, 11);
            this.lblNumeroNotas.Name = "lblNumeroNotas";
            this.lblNumeroNotas.Size = new System.Drawing.Size(123, 17);
            this.lblNumeroNotas.TabIndex = 0;
            this.lblNumeroNotas.Text = "Numero de Notas:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 307);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(721, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xml Divergente";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numeros Saltados";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Xmls";
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(635, 39);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(286, 254);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(324, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(286, 254);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(286, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExtrair
            // 
            this.btnExtrair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExtrair.FlatAppearance.BorderSize = 0;
            this.btnExtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtrair.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExtrair.IconColor = System.Drawing.Color.Black;
            this.btnExtrair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExtrair.Location = new System.Drawing.Point(0, 463);
            this.btnExtrair.Name = "btnExtrair";
            this.btnExtrair.Size = new System.Drawing.Size(963, 42);
            this.btnExtrair.TabIndex = 2;
            this.btnExtrair.Text = "Extrair";
            this.btnExtrair.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxAno);
            this.panel3.Controls.Add(this.comboBoxMes);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 100);
            this.panel3.TabIndex = 3;
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
            this.comboBoxMes.Location = new System.Drawing.Point(3, 37);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(127, 21);
            this.comboBoxMes.TabIndex = 0;
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(135, 37);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(83, 20);
            this.textBoxAno.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mês";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ano";
            // 
            // FormDadosXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExtrair);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDadosXml";
            this.Text = "DadosXml";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorAutorizadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblContadorSaltada;
        private System.Windows.Forms.Label lblContadorCanceladas;
        private System.Windows.Forms.Label lblContadorAutorizadas;
        private System.Windows.Forms.Label lblSaltadas;
        private System.Windows.Forms.Label lblCanceladas;
        private System.Windows.Forms.Label lblAutorizadas;
        private System.Windows.Forms.Label lblContadorNotas;
        private System.Windows.Forms.Label lblNumeroNotas;
        private System.Windows.Forms.Label lblValorXml;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnExtrair;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}