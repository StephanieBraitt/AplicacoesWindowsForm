namespace Exercício4
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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            lstTabuada.Items.Clear();

            txtNumero.Focus();

            for (int i = 1; i <= 10; i++)

            {

                lstTabuada.Items.Add(numero + " x " + i + " = " + (numero * i));
            }
          }
    }
}
