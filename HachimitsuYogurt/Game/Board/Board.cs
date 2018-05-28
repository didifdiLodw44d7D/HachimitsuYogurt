using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HachimitsuYogurt.Game.Koma;

namespace HachimitsuYogurt
{
    class Board
    {
        
        public List<Masu> board = new List<Masu>();
        
        public Board()
        {
            KomaDefine kd = new KomaDefine();

            board.Add(new Masu(11, kd.gote_KY));
            board.Add(new Masu(21, kd.gote_KE));
            board.Add(new Masu(31, kd.gote_GI));
            board.Add(new Masu(41, kd.gote_KI));
            board.Add(new Masu(51, kd.gote_GY));
            board.Add(new Masu(61, kd.gote_KI));
            board.Add(new Masu(71, kd.gote_GI));
            board.Add(new Masu(81, kd.gote_KE));
            board.Add(new Masu(91, kd.gote_KY));

            board.Add(new Masu(12, kd.Null));
            board.Add(new Masu(22, kd.gote_KA));
            board.Add(new Masu(32, kd.Null));
            board.Add(new Masu(42, kd.Null));
            board.Add(new Masu(52, kd.Null));
            board.Add(new Masu(62, kd.Null));
            board.Add(new Masu(72, kd.Null));
            board.Add(new Masu(82, kd.gote_HI));
            board.Add(new Masu(92, kd.Null));

            board.Add(new Masu(13, kd.gote_FU));
            board.Add(new Masu(23, kd.gote_FU));
            board.Add(new Masu(33, kd.gote_FU));
            board.Add(new Masu(43, kd.gote_FU));
            board.Add(new Masu(53, kd.gote_FU));
            board.Add(new Masu(63, kd.gote_FU));
            board.Add(new Masu(73, kd.gote_FU));
            board.Add(new Masu(83, kd.gote_FU));
            board.Add(new Masu(93, kd.gote_FU));

            board.Add(new Masu(14, kd.Null));
            board.Add(new Masu(24, kd.Null));
            board.Add(new Masu(34, kd.Null));
            board.Add(new Masu(44, kd.Null));
            board.Add(new Masu(54, kd.Null));
            board.Add(new Masu(64, kd.Null));
            board.Add(new Masu(74, kd.Null));
            board.Add(new Masu(84, kd.Null));
            board.Add(new Masu(94, kd.Null));

            board.Add(new Masu(15, kd.Null));
            board.Add(new Masu(25, kd.Null));
            board.Add(new Masu(35, kd.Null));
            board.Add(new Masu(45, kd.Null));
            board.Add(new Masu(55, kd.Null));
            board.Add(new Masu(65, kd.Null));
            board.Add(new Masu(75, kd.Null));
            board.Add(new Masu(85, kd.Null));
            board.Add(new Masu(95, kd.Null));

            board.Add(new Masu(16, kd.Null));
            board.Add(new Masu(26, kd.Null));
            board.Add(new Masu(36, kd.Null));
            board.Add(new Masu(46, kd.Null));
            board.Add(new Masu(56, kd.Null));
            board.Add(new Masu(66, kd.Null));
            board.Add(new Masu(76, kd.Null));
            board.Add(new Masu(86, kd.Null));
            board.Add(new Masu(96, kd.Null));

            board.Add(new Masu(17, kd.sente_FU));
            board.Add(new Masu(27, kd.sente_FU));
            board.Add(new Masu(37, kd.sente_FU));
            board.Add(new Masu(47, kd.sente_FU));
            board.Add(new Masu(57, kd.sente_FU));
            board.Add(new Masu(67, kd.sente_FU));
            board.Add(new Masu(77, kd.sente_FU));
            board.Add(new Masu(87, kd.sente_FU));
            board.Add(new Masu(97, kd.sente_FU));

            board.Add(new Masu(18, kd.Null));
            board.Add(new Masu(28, kd.sente_HI));
            board.Add(new Masu(38, kd.Null));
            board.Add(new Masu(48, kd.Null));
            board.Add(new Masu(58, kd.Null));
            board.Add(new Masu(68, kd.Null));
            board.Add(new Masu(78, kd.Null));
            board.Add(new Masu(88, kd.sente_KA));
            board.Add(new Masu(98, kd.Null));

            board.Add(new Masu(19, kd.sente_KY));
            board.Add(new Masu(29, kd.sente_KE));
            board.Add(new Masu(39, kd.sente_GI));
            board.Add(new Masu(49, kd.sente_KI));
            board.Add(new Masu(59, kd.sente_OU));
            board.Add(new Masu(69, kd.sente_KI));
            board.Add(new Masu(79, kd.sente_GI));
            board.Add(new Masu(89, kd.sente_KE));
            board.Add(new Masu(99, kd.sente_KY));
        }

        public void LiftKoma(int masu)
        {
            for (int i = 0; i < 81; i++)
            {
                if (masu == board[i].location)
                    board[i].koma_num = 0;
            }
        }

        public void PutKoma(int masu)
        {
            for (int i = 0; i < 81; i++)
            {
                if (masu == board[i].location)
                {
                    board[i].koma_num = 109;
                }
            }
        }

        public void DisplayBoard()
        {
            foreach(var s in board)
                Console.WriteLine("key = " + s.location + ", value = " + s.koma_num);
        }
    }
}
