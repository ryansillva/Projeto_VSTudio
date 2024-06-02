namespace simulações_para_a_prova
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
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnGeometrica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Location = new System.Drawing.Point(67, 125);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(310, 158);
            this.btnCalculadora.TabIndex = 0;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnGeometrica
            // 
            this.btnGeometrica.Location = new System.Drawing.Point(413, 125);
            this.btnGeometrica.Name = "btnGeometrica";
            this.btnGeometrica.Size = new System.Drawing.Size(305, 158);
            this.btnGeometrica.TabIndex = 1;
            this.btnGeometrica.Text = "Qual é a forma Geométrica";
            this.btnGeometrica.UseVisualStyleBackColor = true;
            this.btnGeometrica.Click += new System.EventHandler(this.btnGeometrica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeometrica);
            this.Controls.Add(this.btnCalculadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnGeometrica;
    }
}

