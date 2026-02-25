namespace ComprimirImagens
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionarPastaOrigem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelecionarDestino = new System.Windows.Forms.Button();
            this.btnComprimir = new System.Windows.Forms.Button();
            this.trackQualidade = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQualidade = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackQualidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPRIMIR IMAGENS";
            // 
            // btnSelecionarPastaOrigem
            // 
            this.btnSelecionarPastaOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarPastaOrigem.Location = new System.Drawing.Point(26, 130);
            this.btnSelecionarPastaOrigem.Name = "btnSelecionarPastaOrigem";
            this.btnSelecionarPastaOrigem.Size = new System.Drawing.Size(105, 29);
            this.btnSelecionarPastaOrigem.TabIndex = 1;
            this.btnSelecionarPastaOrigem.Text = "Selecionar";
            this.btnSelecionarPastaOrigem.UseVisualStyleBackColor = true;
            this.btnSelecionarPastaOrigem.Click += new System.EventHandler(this.btnSelecionarPastaOrigem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pasta origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pasta destino:";
            // 
            // btnSelecionarDestino
            // 
            this.btnSelecionarDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarDestino.Location = new System.Drawing.Point(219, 130);
            this.btnSelecionarDestino.Name = "btnSelecionarDestino";
            this.btnSelecionarDestino.Size = new System.Drawing.Size(105, 29);
            this.btnSelecionarDestino.TabIndex = 3;
            this.btnSelecionarDestino.Text = "Selecionar";
            this.btnSelecionarDestino.UseVisualStyleBackColor = true;
            this.btnSelecionarDestino.Click += new System.EventHandler(this.btnSelecionarDestino_Click);
            // 
            // btnComprimir
            // 
            this.btnComprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprimir.Location = new System.Drawing.Point(120, 297);
            this.btnComprimir.Name = "btnComprimir";
            this.btnComprimir.Size = new System.Drawing.Size(105, 29);
            this.btnComprimir.TabIndex = 5;
            this.btnComprimir.Text = "Comprimir";
            this.btnComprimir.UseVisualStyleBackColor = true;
            this.btnComprimir.Click += new System.EventHandler(this.btnComprimir_Click);
            // 
            // trackQualidade
            // 
            this.trackQualidade.Location = new System.Drawing.Point(69, 207);
            this.trackQualidade.Name = "trackQualidade";
            this.trackQualidade.Size = new System.Drawing.Size(199, 45);
            this.trackQualidade.TabIndex = 6;
            this.trackQualidade.Scroll += new System.EventHandler(this.trackQualidade_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qualidade:";
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualidade.Location = new System.Drawing.Point(158, 255);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(20, 17);
            this.lblQualidade.TabIndex = 8;
            this.lblQualidade.Text = "...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(45, 356);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(268, 23);
            this.progressBar.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "@programacao_diaria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Desenvolvido por Programação Diária";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "JPEG, JPG e TIF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 502);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblQualidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackQualidade);
            this.Controls.Add(this.btnComprimir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelecionarDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelecionarPastaOrigem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vamos reduzir seus arquivos?";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackQualidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionarPastaOrigem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelecionarDestino;
        private System.Windows.Forms.Button btnComprimir;
        private System.Windows.Forms.TrackBar trackQualidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQualidade;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}

