using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CizimUygulamasi
{
    public abstract class Sekil
    {
        public Color Renk { get; set; }
        public Point Baslangic { get; set; }
        public Point Bitis { get; set; }

        public abstract void Ciz(Graphics g);
        public abstract bool IceriyorMu(Point nokta);
        public abstract string SekilTipi { get; }

        public virtual Rectangle GetSinirlar()
        {
            return new Rectangle(
                Math.Min(Baslangic.X, Bitis.X),
                Math.Min(Baslangic.Y, Bitis.Y),
                Math.Abs(Bitis.X - Baslangic.X),
                Math.Abs(Bitis.Y - Baslangic.Y)
            );
        }
    }
}
