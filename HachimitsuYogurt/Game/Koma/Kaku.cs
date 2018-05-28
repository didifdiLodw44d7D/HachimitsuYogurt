using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt.Game.Koma
{
    class Kaku : TobiKomaType
    {
        public Kaku() : base() { }

        public new List<Point> TobiKomaMovePattern()
        {
            List<Point> vector = new List<Point>();

            pattern0.Add(new Point(1, 1));
            pattern0.Add(new Point(2, 2));
            pattern0.Add(new Point(3, 3));
            pattern0.Add(new Point(4, 4));
            pattern0.Add(new Point(5, 5));
            pattern0.Add(new Point(6, 6));
            pattern0.Add(new Point(7, 7));
            pattern0.Add(new Point(8, 8));

            pattern1.Add(new Point(1, -1));
            pattern1.Add(new Point(2, -2));
            pattern1.Add(new Point(3, -3));
            pattern1.Add(new Point(4, -4));
            pattern1.Add(new Point(5, -5));
            pattern1.Add(new Point(6, -6));
            pattern1.Add(new Point(7, -7));
            pattern1.Add(new Point(8, -8));

            pattern2.Add(new Point(-1, -1));
            pattern2.Add(new Point(-2, -2));
            pattern2.Add(new Point(-3, -3));
            pattern2.Add(new Point(-4, -4));
            pattern2.Add(new Point(-5, -5));
            pattern2.Add(new Point(-6, -6));
            pattern2.Add(new Point(-7, -7));
            pattern2.Add(new Point(-8, -8));

            pattern3.Add(new Point(-1, 1));
            pattern3.Add(new Point(-2, 2));
            pattern3.Add(new Point(-3, 3));
            pattern3.Add(new Point(-4, 4));
            pattern3.Add(new Point(-5, 5));
            pattern3.Add(new Point(-6, 6));
            pattern3.Add(new Point(-7, 7));
            pattern3.Add(new Point(-8, 8));
 
            return vector;
        }
    }
}