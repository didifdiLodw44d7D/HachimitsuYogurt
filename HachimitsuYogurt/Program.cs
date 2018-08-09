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

            //飛びゴマ合法手検索手順
            
            /*
             1. 駒のインスタンスを作成
             2. 現在の駒位置を指定
             3. 合法手を検索する
             */
            
            var kaku = new Kaku();

            var a = kaku.TobiKomaMovePattern();

            var b = kaku.MovableKomaMappingBoard(77);

            //foreach (var s in b)
                //Console.WriteLine(s);

            var snapshot = kaku.JudgeGouhoute(true, 77, board);

            int i = 0;

            foreach (var s in snapshot)
            {
                Console.WriteLine("Array[{0}] = {1}{2}", i, s.x, s.y);
                i++;
            }

            /*
             1. 駒のインスタンスを作成
             2. 現在の駒位置を指定
             3. 動けるマスを判定する
             4. 配列座標をマス座標にコンバートする
             5. 合法手を検索する
             */

            var kin = new Kin();

            var c = kin.MovePattern();

            var d = kin.MovableKomaMappingBoard(67, c);

            //foreach (var s in d)
                //Console.WriteLine(s);

            var snap = kin.JudgeGouhoute(true, 67, d, board);

            i = 0;

            foreach (var s in snap)
            {
                Console.WriteLine("Array[{0}] = {1}{2}", i, s.y, s.x);
                i++;
            }
        }
    }
}
