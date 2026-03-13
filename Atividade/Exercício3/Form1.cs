namespace Exercício3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Km, Resultado;
            
            Km = Convert.ToDouble(txtDistancia.Text);
            if (Km <= 220)
            {
                Resultado = Km * 0.50;
            }
            else
            {
                Resultado = Km * 0.45;
            }
           
            txtResultado.Text = Resultado.ToString();
        }
    }
}
