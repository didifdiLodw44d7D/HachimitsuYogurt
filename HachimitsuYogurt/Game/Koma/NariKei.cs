using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt.Game.Koma
{
    class Narikei : FutsuKomaType
    {
        public Narikei() : base() { }

        public new List<Point> MovePattern()
        {
            List<Point> vector = new List<Point>();

            vector.Add(new Point(0, 1));
            vector.Add(new Point(1, 1));
            vector.Add(new Point(1, 0));
            vector.Add(new Point(0, -1));
            vector.Add(new Point(-1, 0));
            vector.Add(new Point(-1, 1));

            return vector;
        }
    }
}
