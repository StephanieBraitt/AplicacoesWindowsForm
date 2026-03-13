namespace Exercício5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCadastroNome.Text) || string.IsNullOrWhiteSpace(txtCadastroSenha.Text))
            {
                MessageBox.Show("Por favor, preencha os campos");
                return;
            }

            Usuarios novoUsuario = new Usuarios();
            novoUsuario.Nome = txtCadastroNome.Text;
            novoUsuario.Senha = txtCadastroSenha.Text;

            Repositório.usuarioCadastrado.Add(novoUsuario);

            MessageBox.Show("Usuário Cadastrado com sucesso");
        }
        internal class Usuarios

        {

            public string Nome { get; set; }

            public string Senha { get; set; }

        }

        internal class Repositório

        {

            public static List<Usuarios> usuarioCadastrado = new List<Usuarios>();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 TelaLogin = new Form1();
            TelaLogin.Show();
            this.Close();
        }
    }
}
