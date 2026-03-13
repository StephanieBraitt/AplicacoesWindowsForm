namespace Exercício2
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
            lbCotacaoDolar = new Label();
            lbQuantidade = new Label();
            label3 = new Label();
            txtCotacao = new TextBox();
            txtDolares = new TextBox();
            txtResultado = new TextBox();
            btnConverter = new Button();
            SuspendLayout();
            // 
            // lbCotacaoDolar
            // 
            lbCotacaoDolar.AutoSize = true;
            lbCotacaoDolar.Location = new Point(40, 43);
            lbCotacaoDolar.Name = "lbCotacaoDolar";
            lbCotacaoDolar.Size = new Size(120, 15);
            lbCotacaoDolar.TabIndex = 0;
            lbCotacaoDolar.Text = "Cotação do dólar R$: ";
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(4, 96);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(156, 15);
            lbQuantidade.TabIndex = 1;
            lbQuantidade.Text = "Quantidade em dólares US$:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 148);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Resultado:";
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(166, 40);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(100, 23);
            txtCotacao.TabIndex = 3;
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(166, 93);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(100, 23);
            txtDolares.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(166, 145);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 5;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(314, 191);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 6;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 226);
            Controls.Add(btnConverter);
            Controls.Add(txtResultado);
            Controls.Add(txtDolares);
            Controls.Add(txtCotacao);
            Controls.Add(label3);
            Controls.Add(lbQuantidade);
            Controls.Add(lbCotacaoDolar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCotacaoDolar;
        private Label lbQuantidade;
        private Label label3;
        private TextBox txtCotacao;
        private TextBox txtDolares;
        private TextBox txtResultado;
        private Button btnConverter;
    }
}
