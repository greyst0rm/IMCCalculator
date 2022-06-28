namespace IMCalculator
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btbCalcular = new System.Windows.Forms.Button();
            this.lblIMC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-9, -6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(503, 78);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CALCULO DE IMC";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(37, 101);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(80, 29);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "PESO";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(32, 133);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(133, 20);
            this.txtValor1.TabIndex = 2;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(366, 183);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(106, 29);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "ALTURA";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(339, 225);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(133, 20);
            this.txtValor2.TabIndex = 4;
            // 
            // btbCalcular
            // 
            this.btbCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCalcular.Location = new System.Drawing.Point(152, 264);
            this.btbCalcular.Name = "btbCalcular";
            this.btbCalcular.Size = new System.Drawing.Size(172, 42);
            this.btbCalcular.TabIndex = 5;
            this.btbCalcular.Text = "CALCULAR";
            this.btbCalcular.UseVisualStyleBackColor = true;
            this.btbCalcular.Click += new System.EventHandler(this.btbCalcular_Click);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(173, 312);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(30, 16);
            this.lblIMC.TabIndex = 6;
            this.lblIMC.Text = "IMC";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMCalculator.Properties.Resources._3vHWR8b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 701);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.btbCalcular);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btbCalcular;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox textBox1;
    }
}

