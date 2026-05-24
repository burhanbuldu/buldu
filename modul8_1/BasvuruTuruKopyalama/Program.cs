using System;

namespace BasvuruTuruKopyalama
{
    class Program
    {
        class Bisiklet
        {
            int hiz = 0;
            int vites = 0;

            public Bisiklet()
            {
                vites = 18;
            }

            public void Hizlan(int artis)
            {
                hiz = hiz + artis;
            }

            public void BilgileriYaz()
            {
                Console.Write("Vites: {0} ", vites);
                Console.WriteLine("Hiz: {0}", hiz);
            }
        }

        static void Main(string[] args)
        {
            Bisiklet bisiklet1 = new Bisiklet();

            Bisiklet bisiklet2 = bisiklet1;

            bisiklet1.Hizlan(20);

            Console.WriteLine("Bisiklet 1 Bilgileri");
            bisiklet1.BilgileriYaz();

            Console.WriteLine();

            Console.WriteLine("Bisiklet 2 Bilgileri");
            bisiklet2.BilgileriYaz();

            Console.ReadLine();
        }
    }
}