namespace Exercício1
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
            lbCelsius = new Label();
            txtCelsius = new TextBox();
            btnConverter = new Button();
            label1 = new Label();
            txtFahrenheit = new TextBox();
            SuspendLayout();
            // 
            // lbCelsius
            // 
            lbCelsius.AutoSize = true;
            lbCelsius.Location = new Point(78, 49);
            lbCelsius.Name = "lbCelsius";
            lbCelsius.Size = new Size(71, 15);
            lbCelsius.TabIndex = 0;
            lbCelsius.Text = "Celsius (°C):";
            lbCelsius.Click += label1_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(155, 46);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(118, 23);
            txtCelsius.TabIndex = 2;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(291, 87);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 3;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 127);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "Fahrenheit:";
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(155, 124);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(118, 23);
            txtFahrenheit.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 239);
            Controls.Add(txtFahrenheit);
            Controls.Add(label1);
            Controls.Add(btnConverter);
            Controls.Add(txtCelsius);
            Controls.Add(lbCelsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCelsius;
        private TextBox txtCelsius;
        private Button btnConverter;
        private Label label1;
        private TextBox txtFahrenheit;
    }
}
