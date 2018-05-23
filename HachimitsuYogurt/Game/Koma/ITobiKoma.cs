using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt.Game.Koma
{
    interface ITobiKoma
    {
        List<Point> TobiKomaMovePattern(string koma_name);
    }
}
