using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneRaporlama
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection(
        @"Server=.\SQLEXPRESS;
        Database=HastaneDB;
        Trusted_Connection=True;");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Listele("SELECT * FROM Hasta");
        }

        void Listele(string sorgu)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (cmbFiltre.Text == "Tümü")
                Listele("SELECT * FROM Hasta");

            else if (cmbFiltre.Text == "Erkek")
                Listele("SELECT * FROM Hasta WHERE Cinsiyet='Erkek'");

            else if (cmbFiltre.Text == "Kadın")
                Listele("SELECT * FROM Hasta WHERE Cinsiyet='Kadın'");

            else if (cmbFiltre.Text == "İzmir")
                Listele("SELECT * FROM Hasta WHERE Sehir='İzmir'");

            else if (cmbFiltre.Text == "50 Yaş Üstü")
                Listele("SELECT * FROM Hasta WHERE Yas > 50");
        }
    }
}