namespace Exercício2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double Cotacao;
            double Dolares;
            double Resultado;

            Cotacao = Convert.ToDouble(txtCotacao.Text);
            Dolares = Convert.ToDouble(txtDolares.Text);

            Resultado = Cotacao * Dolares;
            txtResultado.Text = Resultado.ToString();
        }
    }
}
