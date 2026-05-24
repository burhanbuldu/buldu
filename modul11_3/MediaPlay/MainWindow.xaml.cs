using System;
using System.Windows;
using Microsoft.Win32;

namespace MediaPlay
{
    public partial class MainWindow : Window
    {
        Uri medyaYol;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Medya Dosyası|*.mp4;*.wmv;*.mp3";

            if (dialog.ShowDialog() == true)
            {
                medyaYol = new Uri(dialog.FileName);
                media.Source = medyaYol;

                string[] dosya = dialog.FileName.Split('\\');
                liste.Items.Add(dosya[dosya.Length - 1]);
            }
        }

        private void temizle_Click(object sender, RoutedEventArgs e)
        {
            liste.Items.Clear();
        }

        private void yurut_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void dur_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }

        // 🔥 DÜZELTİLMİŞ SES KODU
        private void ses_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (media != null)
            {
                media.Volume = ses.Value;
            }
        }
    }
}