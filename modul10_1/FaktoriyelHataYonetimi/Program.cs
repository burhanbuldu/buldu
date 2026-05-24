using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Sayı Giriniz: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException("Boş bırakılamaz!");

            int sayi;

            try
            {
                sayi = Convert.ToInt32(input);
            }
            catch
            {
                throw new FormatException("Sadece sayı giriniz!");
            }

            if (sayi < 0)
                throw new Exception("Negatif sayı olamaz!");

            long faktoriyel = 1;

            checked
            {
                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel *= i;
                }
            }

            Console.WriteLine("Sonuç: " + faktoriyel);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("İşlem tamamlandı.");
        }

        Console.ReadLine();
    }
}