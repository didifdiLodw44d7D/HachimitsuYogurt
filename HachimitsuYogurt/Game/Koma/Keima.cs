using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt.Game.Koma
{
    class Keima : TobiKomaType
    {
        public Keima() : base() { }

        public new List<Point> TobiKomaMovePattern()
        {
            List<Point> vector = new List<Point>();

            pattern.Add(new Point(1, 2));
            pattern.Add(new Point(-1, 2));

            return vector;
        }
    }
}