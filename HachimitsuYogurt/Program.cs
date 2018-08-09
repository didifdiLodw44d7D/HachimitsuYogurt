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
                        
            var kaku = new Kaku();

            var a = kaku.TobiKomaMovePattern();

            var b = kaku.MovableKomaMappingBoard(77);

            var snapshot = kaku.JudgeGouhoute(true, 77, board);

            int i = 0;

            foreach (var s in snapshot)
            {
                Console.WriteLine("Array[{0}] = {1}{2}", i, s.x, s.y);
                i++;
            }

            var kin = new Kin();

            var c = kin.MovePattern();

            var d = kin.MovableKomaMappingBoard(55, c);

            var snap = kin.JudgeGouhoute(true, 55, d, board);

            i = 0;

            foreach (var s in snap)
            {
                Console.WriteLine("Array[{0}] = {1}{2}", i, s.y, s.x);
                i++;
            }
        }
    }
}

/*
            var board = new Board();

            //board.LiftKoma(77);

            //board.PutKoma(76);
                        
            var kaku = new Kaku();

            var a = kaku.TobiKomaMovePattern();

            var b = kaku.MovableKomaMappingBoard(77);

            var snapshot = kaku.JudgeGouhoute(true, 77, board);

            int i = 0;

            foreach (var s in snapshot)
            {
                Console.WriteLine("Array[{0}] = {1}{2}", i, s.x, s.y);
                i++;
            }

            var kin = new Kin();

            var c = kin.MovePattern();

            var d = kin.MovableKomaMappingBoard(67, c);

            var snap = kin.JudgeGouhoute(true, 67, d, board);

            i = 0;

            foreach (var s in snap)
            {
                Console.WriteLine("Array[{0}] = {1}{2}", i, s.y, s.x);
                i++;
            }
 
*/
