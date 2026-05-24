using System;

namespace DelegateUygulama
{
    class Program
    {
        // 1) Temsilci (geri dönüş tipi void, parametreli, ref içeriyor)
        public delegate void SiralamaDelegate(ref string[] dizi);

        // Yazdırma delegate (multicast için)
        public delegate void YazdirDelegate(string[] dizi);

        static void Main(string[] args)
        {
            string[] kelimeler = { "elma", "armut", "muz", "kiraz", "portakal" };

            Console.WriteLine("SIRALANMAMIŞ DİZİ:");
            Yazdir(kelimeler);

            // -------------------------
            // MULTICAST DELEGATE
            // -------------------------
            YazdirDelegate yazdirDel = Yazdir;
            yazdirDel += MesajVer;

            Console.WriteLine("\nMULTICAST ÇAĞRISI:");
            yazdirDel(kelimeler);

            // -------------------------
            // TEKLİ (SIRALAMA)
            // -------------------------
            SiralamaDelegate sirala;

            Console.WriteLine("\nA-Z SIRALAMA:");
            sirala = SiralaAZ;
            sirala(ref kelimeler);
            Yazdir(kelimeler);

            Console.WriteLine("\nZ-A SIRALAMA:");
            sirala = SiralaZA;
            sirala(ref kelimeler);
            Yazdir(kelimeler);

            Console.ReadLine();
        }

        // -------------------------
        // METOTLAR (3 adet)
        // -------------------------

        static void Yazdir(string[] dizi)
        {
            Console.WriteLine("Dizi:");
            foreach (string s in dizi)
                Console.Write(s + " ");

            Console.WriteLine("\n");
        }

        static void MesajVer(string[] dizi)
        {
            Console.WriteLine("=> Metot çalıştı.");
        }

        static void SiralaAZ(ref string[] dizi)
        {
            Array.Sort(dizi);
        }

        static void SiralaZA(ref string[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
        }
    }
}