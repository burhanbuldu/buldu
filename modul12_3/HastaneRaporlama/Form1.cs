using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneRaporlama
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(
        @"Server=.\SQLEXPRESS;
        Database=HastaneDB;
        Trusted_Connection=True;");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                "INSERT INTO Hasta (AdSoyad,Cinsiyet,Yas,Sehir,Hastalik,Teshis,KayitTarihi) VALUES (@a,@c,@y,@s,@h,@t,@k)",
                baglanti);

                komut.Parameters.AddWithValue("@a", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@c", txtCinsiyet.Text);
                komut.Parameters.AddWithValue("@y", txtYas.Text);
                komut.Parameters.AddWithValue("@s", txtSehir.Text);
                komut.Parameters.AddWithValue("@h", txtHastalik.Text);
                komut.Parameters.AddWithValue("@t", txtTeshis.Text);
                komut.Parameters.AddWithValue("@k", dtpKayit.Value);

                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt Başarılı");

                txtAdSoyad.Clear();
                txtCinsiyet.Clear();
                txtYas.Clear();
                txtSehir.Clear();
                txtHastalik.Clear();
                txtTeshis.Clear();

                dtpKayit.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}