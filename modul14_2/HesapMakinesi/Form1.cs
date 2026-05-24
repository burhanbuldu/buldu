using System;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetA()
        {
            return Convert.ToInt32(textBox1.Text);
        }

        private int GetB()
        {
            return Convert.ToInt32(textBox2.Text);
        }

        private void buttonTopla_Click(object sender, EventArgs e)
        {
            textBox3.Text = (GetA() + GetB()).ToString();
        }

        private void buttonCikar_Click(object sender, EventArgs e)
        {
            textBox3.Text = (GetA() - GetB()).ToString();
        }

        private void buttonCarp_Click(object sender, EventArgs e)
        {
            textBox3.Text = (GetA() * GetB()).ToString();
        }

        private void buttonBol_Click(object sender, EventArgs e)
        {
            int b = GetB();

            if (b == 0)
            {
                MessageBox.Show("0'a bölme olmaz.");
                return;
            }

            textBox3.Text = (GetA() / b).ToString();
        }
    }
}