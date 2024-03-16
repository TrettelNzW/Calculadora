namespace Calculadora
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



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.num1 = txbPrimeiroNumero.Text;
            controle.num2 = txbSegundoNumero.Text;
            controle.executar();
            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.resultado;
            }
            else
            {
                lblResultado.Text = controle.mensagem;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
