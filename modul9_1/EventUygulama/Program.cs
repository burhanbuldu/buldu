using System;

namespace EventUygulama
{
    // =========================
    // ÜRÜN SINIFI
    // =========================
    class Urun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
    }

    // =========================
    // SEPET SINIFI (EVENT)
    // =========================
    class Sepet
    {
        public delegate void UrunEklendiEventHandler(double toplam);
        public event UrunEklendiEventHandler UrunEklendi;

        private Urun[] urunler = new Urun[100];
        private int sayac = 0;

        public void UrunEkle(Urun u)
        {
            urunler[sayac++] = u;

            double toplam = 0;

            for (int i = 0; i < sayac; i++)
            {
                toplam += urunler[i].Fiyat;
            }

            UrunEklendi?.Invoke(toplam);
        }
    }

    // =========================
    // MAKİNE SINIFI
    // =========================
    class Makine
    {
        public delegate void SicaklikEventHandler(int sicaklik);
        public event SicaklikEventHandler KritikSicaklik;

        Random rnd = new Random();

        public void Calistir()
        {
            while (true)
            {
                int sicaklik = rnd.Next(800, 1200);
                Console.WriteLine("Sıcaklık: " + sicaklik);

                if (sicaklik > 1000)
                {
                    KritikSicaklik?.Invoke(sicaklik);
                    break;
                }
            }
        }
    }

    // =========================
    // PROGRAM
    // =========================
    class Program
    {
        static void Main(string[] args)
        {
            // =========================
            // SEPET UYGULAMASI
            // =========================
            Sepet sepet = new Sepet();
            sepet.UrunEklendi += ToplamGoster;

            Console.WriteLine("ÜRÜN EKLEME BAŞLADI (çıkmak için q yaz)");

            while (true)
            {
                Console.Write("Ürün adı: ");
                string ad = Console.ReadLine();

                if (ad.ToLower() == "q")
                    break;

                Console.Write("Fiyat: ");
                double fiyat = Convert.ToDouble(Console.ReadLine());

                sepet.UrunEkle(new Urun(ad, fiyat));
            }

            // =========================
            // MAKİNE UYGULAMASI
            // =========================
            Console.WriteLine("\nMAKİNE BAŞLADI");

            Makine makine = new Makine();
            makine.KritikSicaklik += MakineyiKapat;

            makine.Calistir();

            Console.WriteLine("\nPROGRAM BİTTİ");
            Console.ReadLine();
        }

        // EVENT METODU 1
        static void ToplamGoster(double toplam)
        {
            Console.WriteLine("SEPET TOPLAM TUTAR: " + toplam);
        }

        // EVENT METODU 2
        static void MakineyiKapat(int sicaklik)
        {
            Console.WriteLine("KRİTİK SICAKLIK! MAKİNE KAPATILDI: " + sicaklik);
        }
    }
}