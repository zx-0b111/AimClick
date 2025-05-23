using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeftSharp.Windows.Input.Keyboard;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ativaTecla = textBox1.Text;
            Properties.Settings.Default.Save();

            if (textBox1.Text.Length == 1)
            {
                MessageBox.Show("Tecla selecionada com sucesso!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.desativaTecla = textBox2.Text;
            Properties.Settings.Default.Save();

            if (textBox2.Text.Length == 1)
            {
                MessageBox.Show("Tecla selecionada com sucesso!");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Update();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Text = "on: " + Properties.Settings.Default.ativaTecla + " | " + "off: " + Properties.Settings.Default.desativaTecla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Configurações salvas com sucesso!");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
