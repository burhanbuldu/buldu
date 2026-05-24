using System;

class Bisiklet
{
    public int Vites;
    public int Hiz;
    public int VitesSayisi;

    public Bisiklet()
    {
        Vites = 1;
        Hiz = 0;
        VitesSayisi = 18;
    }

    public void VitesDegistir(int yeniVites)
    {
        if (yeniVites >= 1 && yeniVites <= VitesSayisi)
            Vites = yeniVites;
    }

    public void Hizlan(int artis)
    {
        Hiz += artis;
    }

    public void FrenYap(int azalma)
    {
        Hiz -= azalma;
        if (Hiz < 0)
            Hiz = 0;
    }

    public void BilgileriYaz()
    {
        Console.WriteLine($"Vites: {Vites} | Hız: {Hiz}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bisiklet bisiklet1 = new Bisiklet();
        Bisiklet bisiklet2 = new Bisiklet();

        Console.WriteLine("Bisiklet 1 Bilgileri:");
        bisiklet1.VitesDegistir(3);
        bisiklet1.Hizlan(20);
        bisiklet1.FrenYap(5);
        bisiklet1.BilgileriYaz();

        Console.WriteLine();

        Console.WriteLine("Bisiklet 2 Bilgileri:");
        bisiklet2.VitesDegistir(5);
        bisiklet2.Hizlan(40);
        bisiklet2.FrenYap(10);
        bisiklet2.BilgileriYaz();

        Console.ReadLine();
    }
}