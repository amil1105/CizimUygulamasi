using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CizimUygulamasi
{
    public class Ucgen : Sekil
    {
        public override void Ciz(Graphics g)
        {
            Rectangle rect = GetSinirlar();
            Point[] points = new Point[3];
            
            // Points for the triangle
            points[0] = new Point(rect.X + rect.Width / 2, rect.Y); // Top
            points[1] = new Point(rect.X, rect.Y + rect.Height); // Bottom left
            points[2] = new Point(rect.X + rect.Width, rect.Y + rect.Height); // Bottom right

            using (Brush b = new SolidBrush(Renk))
            {
                g.FillPolygon(b, points);
            }
        }

        public override bool IceriyorMu(Point nokta)
        {
            Rectangle rect = GetSinirlar();
            Point[] points = new Point[3];
            
            points[0] = new Point(rect.X + rect.Width / 2, rect.Y); // Top
            points[1] = new Point(rect.X, rect.Y + rect.Height); // Bottom left
            points[2] = new Point(rect.X + rect.Width, rect.Y + rect.Height); // Bottom right

            // Check if the point is inside the triangle
            return PointInTriangle(nokta, points[0], points[1], points[2]);
        }

        private bool PointInTriangle(Point pt, Point v1, Point v2, Point v3)
        {
            float d1, d2, d3;
            bool has_neg, has_pos;

            d1 = Sign(pt, v1, v2);
            d2 = Sign(pt, v2, v3);
            d3 = Sign(pt, v3, v1);

            has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);

            return !(has_neg && has_pos);
        }

        private float Sign(Point p1, Point p2, Point p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }

        public override string SekilTipi => "Üçgen";
    }
} 