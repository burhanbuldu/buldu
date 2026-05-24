using System;

namespace Kalitim
{
    class Insan
    {
        public double Boy, Kilo;
        public string Ad;

        public Insan(string ad)
        {
            this.Ad = ad;
            this.Boy = 0.45;
            this.Kilo = 3.5;
        }

        public void Buyu()
        {
            Boy += 0.5;
            Kilo += 0.5;
        }
    }

    class Ogrenci : Insan
    {
        public Ogrenci(string ad)
            : base(ad)
        {

        }

        public new void Buyu()
        {
            this.Boy += 1.5;
            this.Kilo += 1.5;
        }
    }

    class Ogretmen : Insan
    {
        public Ogretmen(string ad)
            : base(ad)
        {

        }
    }

    class Mudur : Insan
    {
        public Mudur(string ad)
            : base(ad)
        {

        }
    }
}