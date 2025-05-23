namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rodando com sucesso");

            Clique.Clicar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
