using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci Sayı: ");
        int birinci = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci Sayı: ");
        int ikinci = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n--- FOR DÖNGÜSÜ ---");
        int toplamFor = 0;

        for (int i = birinci; i <= ikinci; i++)
        {
            toplamFor += i;
        }

        Console.WriteLine("Toplam: " + toplamFor);

        Console.WriteLine("\n--- WHILE DÖNGÜSÜ ---");
        int toplamWhile = 0;
        int sayac = birinci;

        while (sayac <= ikinci)
        {
            toplamWhile += sayac;
            sayac++;
        }

        Console.WriteLine("Toplam: " + toplamWhile);

        Console.WriteLine("\n--- DO-WHILE DÖNGÜSÜ ---");
        int toplamDoWhile = 0;
        int i2 = birinci;

        do
        {
            toplamDoWhile += i2;
            i2++;
        }
        while (i2 <= ikinci);

        Console.WriteLine("Toplam: " + toplamDoWhile);

        Console.ReadLine();
    }
}