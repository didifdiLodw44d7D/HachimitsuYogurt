using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt.Game.Koma
{
    class Fu : FutsuKomaType
    {
        public Fu() : base() { }

        public new List<Point> MovePattern()
        {
            List<Point> vector = new List<Point>();

            vector.Add(new Point(0, 1));

            return vector;
        }
    }
}
