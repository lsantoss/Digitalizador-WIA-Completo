﻿namespace Digitalizador_WIA_Completo___WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gboxConfiguracao = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGerarPDF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.lblFomato = new System.Windows.Forms.Label();
            this.btnScanner = new System.Windows.Forms.Button();
            this.btnLocalDestino = new System.Windows.Forms.Button();
            this.txtLocalDestino = new System.Windows.Forms.TextBox();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.lblLocalDestino = new System.Windows.Forms.Label();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.lblScanners = new System.Windows.Forms.Label();
            this.lstScanners = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.gboxConfiguracao.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxConfiguracao
            // 
            this.gboxConfiguracao.Controls.Add(this.groupBox3);
            this.gboxConfiguracao.Controls.Add(this.groupBox2);
            this.gboxConfiguracao.Controls.Add(this.btnLocalDestino);
            this.gboxConfiguracao.Controls.Add(this.txtLocalDestino);
            this.gboxConfiguracao.Controls.Add(this.txtNomeArquivo);
            this.gboxConfiguracao.Controls.Add(this.lblLocalDestino);
            this.gboxConfiguracao.Controls.Add(this.lblNomeArquivo);
            this.gboxConfiguracao.Controls.Add(this.lblScanners);
            this.gboxConfiguracao.Controls.Add(this.lstScanners);
            this.gboxConfiguracao.Location = new System.Drawing.Point(13, 13);
            this.gboxConfiguracao.Name = "gboxConfiguracao";
            this.gboxConfiguracao.Size = new System.Drawing.Size(224, 662);
            this.gboxConfiguracao.TabIndex = 0;
            this.gboxConfiguracao.TabStop = false;
            this.gboxConfiguracao.Text = "Configurações";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGerarPDF);
            this.groupBox3.Location = new System.Drawing.Point(6, 571);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 73);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gerar Arquivo PDF";
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.Location = new System.Drawing.Point(10, 22);
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Size = new System.Drawing.Size(188, 39);
            this.btnGerarPDF.TabIndex = 10;
            this.btnGerarPDF.Text = "Gerar PDF";
            this.btnGerarPDF.UseVisualStyleBackColor = true;
            this.btnGerarPDF.Click += new System.EventHandler(this.btnGerarPDF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFormato);
            this.groupBox2.Controls.Add(this.lblFomato);
            this.groupBox2.Controls.Add(this.btnScanner);
            this.groupBox2.Location = new System.Drawing.Point(6, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 105);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerar Arquivo de Imagem";
            // 
            // cbFormato
            // 
            this.cbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "TIFF",
            "BMP",
            "GIF"});
            this.cbFormato.Location = new System.Drawing.Point(10, 39);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(188, 21);
            this.cbFormato.TabIndex = 7;
            // 
            // lblFomato
            // 
            this.lblFomato.AutoSize = true;
            this.lblFomato.Location = new System.Drawing.Point(7, 23);
            this.lblFomato.Name = "lblFomato";
            this.lblFomato.Size = new System.Drawing.Size(45, 13);
            this.lblFomato.TabIndex = 3;
            this.lblFomato.Text = "Formato";
            // 
            // btnScanner
            // 
            this.btnScanner.Location = new System.Drawing.Point(10, 69);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(188, 23);
            this.btnScanner.TabIndex = 9;
            this.btnScanner.Text = "Gerar Imagem";
            this.btnScanner.UseVisualStyleBackColor = true;
            this.btnScanner.Click += new System.EventHandler(this.BtnScanner_Click);
            // 
            // btnLocalDestino
            // 
            this.btnLocalDestino.Location = new System.Drawing.Point(16, 414);
            this.btnLocalDestino.Name = "btnLocalDestino";
            this.btnLocalDestino.Size = new System.Drawing.Size(188, 23);
            this.btnLocalDestino.TabIndex = 8;
            this.btnLocalDestino.Text = "Modificar Destino";
            this.btnLocalDestino.UseVisualStyleBackColor = true;
            this.btnLocalDestino.Click += new System.EventHandler(this.BtnLocalDestino_Click);
            // 
            // txtLocalDestino
            // 
            this.txtLocalDestino.Enabled = false;
            this.txtLocalDestino.Location = new System.Drawing.Point(16, 388);
            this.txtLocalDestino.Name = "txtLocalDestino";
            this.txtLocalDestino.Size = new System.Drawing.Size(188, 20);
            this.txtLocalDestino.TabIndex = 6;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(16, 337);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(188, 20);
            this.txtNomeArquivo.TabIndex = 5;
            // 
            // lblLocalDestino
            // 
            this.lblLocalDestino.AutoSize = true;
            this.lblLocalDestino.Location = new System.Drawing.Point(13, 372);
            this.lblLocalDestino.Name = "lblLocalDestino";
            this.lblLocalDestino.Size = new System.Drawing.Size(87, 13);
            this.lblLocalDestino.TabIndex = 4;
            this.lblLocalDestino.Text = "Local de Destino";
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Location = new System.Drawing.Point(13, 321);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(89, 13);
            this.lblNomeArquivo.TabIndex = 2;
            this.lblNomeArquivo.Text = "Nome do Arquivo";
            // 
            // lblScanners
            // 
            this.lblScanners.AutoSize = true;
            this.lblScanners.Location = new System.Drawing.Point(13, 31);
            this.lblScanners.Name = "lblScanners";
            this.lblScanners.Size = new System.Drawing.Size(92, 13);
            this.lblScanners.TabIndex = 1;
            this.lblScanners.Text = "Lista de Scanners";
            // 
            // lstScanners
            // 
            this.lstScanners.FormattingEnabled = true;
            this.lstScanners.Location = new System.Drawing.Point(16, 47);
            this.lstScanners.Name = "lstScanners";
            this.lstScanners.Size = new System.Drawing.Size(188, 238);
            this.lstScanners.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(253, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 662);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo Gerado";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(19, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(498, 613);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxConfiguracao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitalizador WIA Completo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxConfiguracao.ResumeLayout(false);
            this.gboxConfiguracao.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxConfiguracao;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Button btnLocalDestino;
        private System.Windows.Forms.ComboBox cbFormato;
        private System.Windows.Forms.TextBox txtLocalDestino;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label lblLocalDestino;
        private System.Windows.Forms.Label lblFomato;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.Label lblScanners;
        private System.Windows.Forms.ListBox lstScanners;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnGerarPDF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

