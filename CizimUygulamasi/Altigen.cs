using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CizimUygulamasi
{
    public class Altigen : Sekil
    {
        public override Rectangle GetSinirlar()
        {
            int minX = Math.Min(Baslangic.X, Bitis.X);
            int minY = Math.Min(Baslangic.Y, Bitis.Y);
            int width = Math.Abs(Bitis.X - Baslangic.X);
            int height = Math.Abs(Bitis.Y - Baslangic.Y);
            
            double ratio = Math.Sqrt(3) / 2;
            
            if (width > height * ratio)
            {
                int newWidth = (int)(height * ratio);
                minX = minX + (width - newWidth) / 2;
                width = newWidth;
            }
            else if (height > width / ratio)
            {
                int newHeight = (int)(width / ratio);
                minY = minY + (height - newHeight) / 2;
                height = newHeight;
            }
            
            return new Rectangle(minX, minY, width, height);
        }
        
        public override void Ciz(Graphics g)
        {
            Rectangle rect = GetSinirlar();
            Point[] points = new Point[6];
            
            int centerX = rect.X + rect.Width / 2;
            int centerY = rect.Y + rect.Height / 2;
            
            int radius = Math.Min(rect.Width, rect.Height) / 2;
            
            for (int i = 0; i < 6; i++)
            {
                double angle = 2 * Math.PI / 6 * i;
                points[i] = new Point(
                    (int)(centerX + radius * Math.Cos(angle)),
                    (int)(centerY + radius * Math.Sin(angle))
                );
            }

            using (Brush b = new SolidBrush(Renk))
            {
                g.FillPolygon(b, points);
            }
        }

        public override bool IceriyorMu(Point nokta)
        {
            Rectangle rect = GetSinirlar();
            Point[] points = new Point[6];
            
            int centerX = rect.X + rect.Width / 2;
            int centerY = rect.Y + rect.Height / 2;
            
            int radius = Math.Min(rect.Width, rect.Height) / 2;
            
            for (int i = 0; i < 6; i++)
            {
                double angle = 2 * Math.PI / 6 * i;
                points[i] = new Point(
                    (int)(centerX + radius * Math.Cos(angle)),
                    (int)(centerY + radius * Math.Sin(angle))
                );
            }

            return PointInPolygon(nokta, points);
        }

        private bool PointInPolygon(Point point, Point[] polygon)
        {
            bool result = false;
            int j = polygon.Length - 1;
            
            for (int i = 0; i < polygon.Length; i++)
            {
                if (polygon[i].Y < point.Y && polygon[j].Y >= point.Y || 
                    polygon[j].Y < point.Y && polygon[i].Y >= point.Y)
                {
                    if (polygon[i].X + (point.Y - polygon[i].Y) / 
                        (polygon[j].Y - polygon[i].Y) * 
                        (polygon[j].X - polygon[i].X) < point.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }

        public override string SekilTipi => "Altıgen";
    }
} 