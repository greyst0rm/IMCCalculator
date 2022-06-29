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
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btbCalcular = new System.Windows.Forms.Button();
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitulo.Location = new System.Drawing.Point(-11, -4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(503, 78);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CALCULO DE IMC";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.Honeydew;
            this.lblPeso.Location = new System.Drawing.Point(358, 93);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(91, 33);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "PESO";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(339, 129);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(133, 20);
            this.txtPeso.TabIndex = 2;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.Info;
            this.lblAltura.Location = new System.Drawing.Point(333, 181);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(140, 33);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "ALTURA";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(339, 217);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(133, 20);
            this.txtAltura.TabIndex = 4;
            // 
            // btbCalcular
            // 
            this.btbCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCalcular.ForeColor = System.Drawing.Color.Black;
            this.btbCalcular.Location = new System.Drawing.Point(157, 253);
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
            this.lblIMC.Location = new System.Drawing.Point(173, 304);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(30, 16);
            this.lblIMC.TabIndex = 6;
            this.lblIMC.Text = "IMC";
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(209, 304);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.ReadOnly = true;
            this.txtIMC.Size = new System.Drawing.Size(120, 20);
            this.txtIMC.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(206, 339);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(49, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Situação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMCalculator.Properties.Resources.Captura_de_tela_2022_06_28_213748;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 701);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.btbCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtPeso);
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
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btbCalcular;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label lblResultado;
    }
}

