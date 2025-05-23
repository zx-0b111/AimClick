using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += AtivaTecla;
            this.KeyPress += DesativaTecla;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void AtivaTecla(object sender, KeyPressEventArgs e)
        {
            string aciona = Properties.Settings.Default.ativaTecla;
            char chamaTecla = aciona[0];

            if (e.KeyChar == chamaTecla)
            {
                e.Handled = true;
                label3.ForeColor = Color.Blue;
                label3.Text = " ATIVADO";
                Clique.Clicar();
            }
        }

        public void DesativaTecla(object sender, KeyPressEventArgs e)
        {
            string desaciona = Properties.Settings.Default.desativaTecla;
            char desativaTecla = desaciona[0];

            if (e.KeyChar == desativaTecla)
            {
                e.Handled = true;

                Application.Exit();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
