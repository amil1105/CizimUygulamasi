using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CizimUygulamasi
{
    public class SekilManager
    {
        public List<Sekil> Sekiller { get; set; } = new();
        public Sekil? SeciliSekil { get; set; }

        public void SekilEkle(Sekil s) => Sekiller.Add(s);

        public void CizHepsi(Graphics g)
        {
            foreach (var sekil in Sekiller.Where(s => s != SeciliSekil))
            {
                sekil.Ciz(g);
            }

            if (SeciliSekil != null)
            {
                var r = SeciliSekil.GetSinirlar();

                int padding = 5; 
                Rectangle biggerRect = new Rectangle(
                    r.X - padding,
                    r.Y - padding,
                    r.Width + (padding * 2),
                    r.Height + (padding * 2)
                );

                using (Brush fillBrush = new SolidBrush(Color.FromArgb(80, Color.DarkOliveGreen)))
                {
                    g.FillRectangle(fillBrush, biggerRect);
                }

                SeciliSekil.Ciz(g);
            }
        }

        public void SekilSec(Point nokta)
        {
            SeciliSekil = Sekiller.LastOrDefault(s => s.IceriyorMu(nokta));
        }

        public void SilSecili()
        {
            if (SeciliSekil != null)
                Sekiller.Remove(SeciliSekil);
        }

        public void Temizle()
        {
            Sekiller.Clear();
            SeciliSekil = null;
        }
    }
}
