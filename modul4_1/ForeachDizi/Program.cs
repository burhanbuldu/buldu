using System;

class Program
{
    static void Main(string[] args)
    {
        // Dizi tanımlama
        int[] sayi = { 1, 2, 3, 4 };

        // Toplam değişkeni
        int toplam = 0;

        // Foreach kullanarak toplama
        foreach (int i in sayi)
        {
            toplam = toplam + i;
        }

        // Sonucu ekrana yazdırma
        Console.WriteLine(toplam);

        // Ekranın kapanmaması için
        Console.ReadLine();
    }
}