using System;

class Program
{
    static void Main()
    {
        // Değerler
        int a = 16;
        int b = 12;
        int c = 10;

        // 1. verilen formül
        int islem1 = a + c / (b - c) * 10;

        Console.WriteLine("Parantezli işlem sonucu: " + islem1);

        // 2. parantezsiz yazım
        int islem2 = a + c / b - c * 10;

        Console.WriteLine("Parantezsiz işlem sonucu: " + islem2);

        // 3. pozitif mi negatif mi
        bool pozitifMi1 = islem1 > 0;
        bool pozitifMi2 = islem2 > 0;

        Console.WriteLine("1. sonuç pozitif mi? " + pozitifMi1);
        Console.WriteLine("2. sonuç pozitif mi? " + pozitifMi2);

        // bekle
        Console.ReadLine();
    }
}