using System.Windows;
using System.Windows.Controls;

namespace MetotluToplama
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // BUTON CLICK
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            islem();
        }

        // ÖDEVİN İSTEDİĞİ METOT
        public void islem()
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);

            int sonuc = sayi1 + sayi2;

            textBox3.Text = sonuc.ToString();
        }
    }
}