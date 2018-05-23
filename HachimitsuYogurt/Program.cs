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

            var pattern = new MovablePattern();

            var f_koma = new FutsuKomaType(); // = new Kin();
            var t_koma = new Kaku(typeof(Kaku));

            var reg = new HachimitsuYogurt.Game.Regulation.Regulation();

            t_koma.SashitePattern(t_koma);

            var b = t_koma.TobiKomaMovePattern("Kaku");

            var a = t_koma.MovableKomaMappingBoard(77, null, 0);

            foreach (var s in a)
                Console.WriteLine(s);

            var snapshot = t_koma.JudgeGouhoute(true, 76, board);

            int i = 0;

            foreach (var s in snapshot)
            {
                Console.WriteLine("Array[{0}] = {1}", i, s);
                i++;
            }
        }
    }
}

/*
        static void Main(string[] args)
        {
            var board = new Board();

            board.LiftKoma(77);

            board.PutKoma(76);
            
            var pattern = new MovablePattern();

            var type = new KomaType();

            // 角を持ち上げたとき
            pattern.SashitePattern(type.koma["SENTE-KA"], true, 88, board);

            var reg = new Regulation();

            var mappingarray = reg.MovableKomaMappingBoard(88, pattern);

            foreach (var s in mappingarray)
                Console.WriteLine("MappingArray = " + s);

            var snapshot = reg.JudgeMovableMasu(true, 88, mappingarray, board);

            int i = 0;
            foreach (var s in snapshot)
            {
                Console.WriteLine("Array[{0}] = " + s, i);
                i++;
            }
            
            //スナップショットを走査して、"True"に対して、評価値を振っていく。
            
            board.DisplayBoard();
        } 
*/
