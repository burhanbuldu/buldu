using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kat numarası giriniz (0-3): ");
        int kat = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n--- IF-ELSE SONUCU ---");

        // IF-ELSE
        if (kat == 0)
        {
            Console.WriteLine("Zemin kat: Kantin, Güvenlik, Spor Salonu");
        }
        else if (kat == 1)
        {
            Console.WriteLine("1. Kat: Matematik, Fen Bilgisi sınıfları");
        }
        else if (kat == 2)
        {
            Console.WriteLine("2. Kat: Türkçe, Sosyal Bilgiler sınıfları");
        }
        else if (kat == 3)
        {
            Console.WriteLine("3. Kat: Müdür odası, Rehberlik servisi");
        }
        else
        {
            Console.WriteLine("Lütfen 0-3 arasında bir kat numarası giriniz...");
        }

        Console.WriteLine("\n--- SWITCH SONUCU ---");

        // SWITCH
        switch (kat)
        {
            case 0:
                Console.WriteLine("Zemin kat: Kantin, Güvenlik, Spor Salonu");
                break;

            case 1:
                Console.WriteLine("1. Kat: Matematik, Fen Bilgisi sınıfları");
                break;

            case 2:
                Console.WriteLine("2. Kat: Türkçe, Sosyal Bilgiler sınıfları");
                break;

            case 3:
                Console.WriteLine("3. Kat: Müdür odası, Rehberlik servisi");
                break;

            default:
                Console.WriteLine("Lütfen 0-3 arasında bir kat numarası giriniz...");
                break;
        }

        Console.ReadLine();
    }
}