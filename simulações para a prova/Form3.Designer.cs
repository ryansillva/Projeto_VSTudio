namespace simulações_para_a_prova
{
    partial class Form3
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
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbQuadrilatero = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtLados = new System.Windows.Forms.TextBox();
            this.txtTriangulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(186, 51);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(82, 24);
            this.rbCirculo.TabIndex = 0;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(286, 51);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(99, 24);
            this.rbTriangulo.TabIndex = 1;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbQuadrilatero
            // 
            this.rbQuadrilatero.AutoSize = true;
            this.rbQuadrilatero.Location = new System.Drawing.Point(391, 51);
            this.rbQuadrilatero.Name = "rbQuadrilatero";
            this.rbQuadrilatero.Size = new System.Drawing.Size(121, 24);
            this.rbQuadrilatero.TabIndex = 2;
            this.rbQuadrilatero.TabStop = true;
            this.rbQuadrilatero.Text = "Quadrilatero";
            this.rbQuadrilatero.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(154, 134);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(380, 129);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtLados
            // 
            this.txtLados.Location = new System.Drawing.Point(339, 92);
            this.txtLados.Name = "txtLados";
            this.txtLados.Size = new System.Drawing.Size(142, 26);
            this.txtLados.TabIndex = 4;
            // 
            // txtTriangulo
            // 
            this.txtTriangulo.AutoSize = true;
            this.txtTriangulo.Location = new System.Drawing.Point(206, 92);
            this.txtTriangulo.Name = "txtTriangulo";
            this.txtTriangulo.Size = new System.Drawing.Size(127, 20);
            this.txtTriangulo.TabIndex = 13;
            this.txtTriangulo.Text = "Informe os lados";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTriangulo);
            this.Controls.Add(this.txtLados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rbQuadrilatero);
            this.Controls.Add(this.rbTriangulo);
            this.Controls.Add(this.rbCirculo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbQuadrilatero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtLados;
        private System.Windows.Forms.Label txtTriangulo;
    }
}