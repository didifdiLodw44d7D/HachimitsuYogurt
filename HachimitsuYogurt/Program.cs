using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HachimitsuYogurt.Game.Koma;

namespace HachimitsuYogurt
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();

            //board.LiftKoma(77);

            //board.PutKoma(76);

            var t_koma = new Kaku();

            var b = t_koma.TobiKomaMovePattern();

            var a = t_koma.MovableKomaMappingBoard(77);

            foreach (var s in a)
                Console.WriteLine(s);

            var snapshot = t_koma.JudgeGouhoute(true, 77, board);

            int i = 0;

            foreach (var s in snapshot)
            {
                Console.WriteLine("Array[{0}] = {1}", i, s);
                i++;
            }

            var kin = new Kin();

            var c = kin.MovePattern();

            var d = kin.MovableKomaMappingBoard(68, c);

            foreach (var s in d)
                Console.WriteLine(s);

            var snap = kin.JudgeMovableMasu(true, 68, d, board);

            var e = kin.ConvertPoint(d);

            var snapshot_ = kin.JudgeGouhoute(e, true, 68, board);

            i = 0;

            foreach (var s in snapshot_)
            {
                Console.WriteLine("Array[{0}] = {1}", i, s);
                i++;
            }
        }
    }
}
