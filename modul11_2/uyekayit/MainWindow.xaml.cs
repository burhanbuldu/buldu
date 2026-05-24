using System.Windows;

namespace UyeKayit
{
    public partial class MainWindow : Window
    {
        Uye uye = new Uye();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = uye;
        }
    }
}