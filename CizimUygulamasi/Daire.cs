using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CizimUygulamasi
{
    public class Daire : Sekil
    {
        public override void Ciz(Graphics g)
        {
            using (Brush b = new SolidBrush(Renk))
            {
                g.FillEllipse(b, GetSinirlar());
            }
        }

        public override bool IceriyorMu(Point nokta)
        {
            return GetSinirlar().Contains(nokta);
        }

        public override string SekilTipi => "Daire";
    }
}
