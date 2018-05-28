using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt.Game.Koma
{
    class Ryuou : TobiKomaType
    {
        public Ryuou() : base() { }

        public new List<Point> TobiKomaMovePattern()
        {
            List<Point> vector = new List<Point>();

            pattern.Add(new Point(1, 1));
            pattern.Add(new Point(1, -1));
            pattern.Add(new Point(-1, -1));
            pattern.Add(new Point(-1, 1));

            pattern0.Add(new Point(1, 0));
            pattern0.Add(new Point(2, 0));
            pattern0.Add(new Point(3, 0));
            pattern0.Add(new Point(4, 0));
            pattern0.Add(new Point(5, 0));
            pattern0.Add(new Point(6, 0));
            pattern0.Add(new Point(7, 0));
            pattern0.Add(new Point(8, 0));

            pattern1.Add(new Point(0, 1));
            pattern1.Add(new Point(0, 2));
            pattern1.Add(new Point(0, 3));
            pattern1.Add(new Point(0, 4));
            pattern1.Add(new Point(0, 5));
            pattern1.Add(new Point(0, 6));
            pattern1.Add(new Point(0, 7));
            pattern1.Add(new Point(0, 8));

            pattern2.Add(new Point(-1, 0));
            pattern2.Add(new Point(-2, 0));
            pattern2.Add(new Point(-3, 0));
            pattern2.Add(new Point(-4, 0));
            pattern2.Add(new Point(-5, 0));
            pattern2.Add(new Point(-6, 0));
            pattern2.Add(new Point(-7, 0));
            pattern2.Add(new Point(-8, 0));

            pattern3.Add(new Point(0, -1));
            pattern3.Add(new Point(0, -2));
            pattern3.Add(new Point(0, -3));
            pattern3.Add(new Point(0, -4));
            pattern3.Add(new Point(0, -5));
            pattern3.Add(new Point(0, -6));
            pattern3.Add(new Point(0, -7));
            pattern3.Add(new Point(0, -8));

            return vector;

        }
    }
}
