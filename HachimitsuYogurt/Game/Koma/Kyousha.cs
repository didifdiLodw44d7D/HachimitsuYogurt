using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt.Game.Koma
{
    class Kyousha : TobiKomaType
    {
        public Kyousha() : base() { }

        public new List<Point> TobiKomaMovePattern()
        {
            List<Point> vector = new List<Point>();

            pattern0.Add(new Point(1, 0));
            pattern0.Add(new Point(2, 0));
            pattern0.Add(new Point(3, 0));
            pattern0.Add(new Point(4, 0));
            pattern0.Add(new Point(5, 0));
            pattern0.Add(new Point(6, 0));
            pattern0.Add(new Point(7, 0));
            pattern0.Add(new Point(8, 0));

            return vector;

        }
    }
}