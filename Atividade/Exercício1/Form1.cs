namespace Exercício1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double Celsius, resultado;
            Celsius = Convert.ToDouble(txtCelsius.Text);


            resultado = (Celsius * 9 / 5) + 32;

            txtFahrenheit.Text = resultado.ToString();
        }
    }
}
