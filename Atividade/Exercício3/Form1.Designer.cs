namespace Exercício3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbDistancia = new Label();
            lbResultado = new Label();
            txtDistancia = new TextBox();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lbDistancia
            // 
            lbDistancia.AutoSize = true;
            lbDistancia.Location = new Point(27, 64);
            lbDistancia.Name = "lbDistancia";
            lbDistancia.Size = new Size(86, 15);
            lbDistancia.TabIndex = 0;
            lbDistancia.Text = "Distância (km):";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(51, 118);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(62, 15);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado:";
            // 
            // txtDistancia
            // 
            txtDistancia.AcceptsReturn = true;
            txtDistancia.Location = new Point(119, 61);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(94, 23);
            txtDistancia.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(228, 86);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(119, 115);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(94, 23);
            txtResultado.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 157);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtDistancia);
            Controls.Add(lbResultado);
            Controls.Add(lbDistancia);
            Name = "Form1";
            Text = "Preço da passagem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDistancia;
        private Label lbResultado;
        private TextBox txtDistancia;
        private Button btnCalcular;
        private TextBox txtResultado;
    }
}
