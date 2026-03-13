namespace Exercício5
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
            btnCadastroSalvar = new Button();
            lbCadastroSenha = new Label();
            lbCadastroNome = new Label();
            txtCadastroSenha = new TextBox();
            txtCadastroNome = new TextBox();
            lbCadastro = new Label();
            SuspendLayout();
            // 
            // btnCadastroSalvar
            // 
            btnCadastroSalvar.Location = new Point(150, 243);
            btnCadastroSalvar.Name = "btnCadastroSalvar";
            btnCadastroSalvar.Size = new Size(75, 23);
            btnCadastroSalvar.TabIndex = 12;
            btnCadastroSalvar.Text = "Salvar";
            btnCadastroSalvar.UseVisualStyleBackColor = true;
            btnCadastroSalvar.Click += btnCadastroSalvar_Click;
            // 
            // lbCadastroSenha
            // 
            lbCadastroSenha.AutoSize = true;
            lbCadastroSenha.Location = new Point(35, 191);
            lbCadastroSenha.Name = "lbCadastroSenha";
            lbCadastroSenha.Size = new Size(39, 15);
            lbCadastroSenha.TabIndex = 11;
            lbCadastroSenha.Text = "Senha";
            // 
            // lbCadastroNome
            // 
            lbCadastroNome.AutoSize = true;
            lbCadastroNome.Location = new Point(34, 109);
            lbCadastroNome.Name = "lbCadastroNome";
            lbCadastroNome.Size = new Size(40, 15);
            lbCadastroNome.TabIndex = 10;
            lbCadastroNome.Text = "Nome";
            // 
            // txtCadastroSenha
            // 
            txtCadastroSenha.Location = new Point(80, 185);
            txtCadastroSenha.Name = "txtCadastroSenha";
            txtCadastroSenha.Size = new Size(231, 23);
            txtCadastroSenha.TabIndex = 9;
            // 
            // txtCadastroNome
            // 
            txtCadastroNome.Location = new Point(80, 106);
            txtCadastroNome.Name = "txtCadastroNome";
            txtCadastroNome.Size = new Size(231, 23);
            txtCadastroNome.TabIndex = 8;
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.Font = new Font("Segoe UI", 20F);
            lbCadastro.Location = new Point(118, 25);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(123, 37);
            lbCadastro.TabIndex = 7;
            lbCadastro.Text = "Cadastro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 341);
            Controls.Add(btnCadastroSalvar);
            Controls.Add(lbCadastroSenha);
            Controls.Add(lbCadastroNome);
            Controls.Add(txtCadastroSenha);
            Controls.Add(txtCadastroNome);
            Controls.Add(lbCadastro);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCadastroSalvar;
        private Label lbCadastroSenha;
        private Label lbCadastroNome;
        private TextBox txtCadastroSenha;
        private TextBox txtCadastroNome;
        private Label lbCadastro;
    }
}
