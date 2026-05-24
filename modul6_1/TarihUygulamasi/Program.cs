using System;

namespace TarihUygulamasi
{
    struct Tarih
    {
        // Elemanlar
        public int gun;
        public int ay;
        public int yil;

        // Kurucu Metot
        public Tarih(int g, int a, int y)
        {
            gun = g;
            ay = a;
            yil = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Kurucu kullanılarak değer gönderiliyor
            Tarih t1 = new Tarih(21, 5, 2026);

            // Ekrana yazdırma
            Console.WriteLine("Gun : " + t1.gun);
            Console.WriteLine("Ay  : " + t1.ay);
            Console.WriteLine("Yil : " + t1.yil);

            Console.ReadLine();
        }
    }
}