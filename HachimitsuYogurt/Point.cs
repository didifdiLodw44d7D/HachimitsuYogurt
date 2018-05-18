using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt
{
    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class PointEx
    {
        public int x;
        public int y;
        public int now_state_koma;

        public PointEx(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public PointEx(int x, int y, int now_state_koma)
        {
            this.x = x;
            this.y = y;
            this.now_state_koma = now_state_koma;
        }
    }
}
