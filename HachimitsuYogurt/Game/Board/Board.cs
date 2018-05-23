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
        //public KomaType type = new KomaType();
        
        public Board()
        {
            /*
            koma.Add(sente_OU, 101);
            koma.Add(sente_GY, 102);
            koma.Add(sente_KI, 103);
            koma.Add(sente_GI, 104);
            koma.Add(sente_KE, 105);
            koma.Add(sente_KY, 106);
            koma.Add(sente_HI, 107);
            koma.Add(sente_KA, 108);
            koma.Add(sente_FU, 109);
            koma.Add(sente_NE, 110);
            koma.Add(sente_NK, 111);
            koma.Add(sente_NG, 112);
            koma.Add(sente_RY, 113);
            koma.Add(sente_RM, 114);
            koma.Add(sente_TK, 115);

            koma.Add(gote_OU, 201);
            koma.Add(gote_GY, 202);
            koma.Add(gote_KI, 203);
            koma.Add(gote_GI, 204);
            koma.Add(gote_KE, 205);
            koma.Add(gote_KY, 206);
            koma.Add(gote_HI, 207);
            koma.Add(gote_KA, 208);
            koma.Add(gote_FU, 209);
            koma.Add(gote_NE, 210);
            koma.Add(gote_NK, 211);
            koma.Add(gote_NG, 212);
            koma.Add(gote_RY, 213);
            koma.Add(gote_RM, 214);
            koma.Add(gote_TK, 215);
            */

            board.Add(new Masu(11, 206));
            board.Add(new Masu(21, 205));
            board.Add(new Masu(31, 204));
            board.Add(new Masu(41, 203));
            board.Add(new Masu(51, 202));
            board.Add(new Masu(61, 203));
            board.Add(new Masu(71, 204));
            board.Add(new Masu(81, 205));
            board.Add(new Masu(91, 206));

            board.Add(new Masu(12, 0));
            board.Add(new Masu(22, 208));
            board.Add(new Masu(32, 0));
            board.Add(new Masu(42, 0));
            board.Add(new Masu(52, 0));
            board.Add(new Masu(62, 0));
            board.Add(new Masu(72, 0));
            board.Add(new Masu(82, 207));
            board.Add(new Masu(92, 0));

            board.Add(new Masu(13, 209));
            board.Add(new Masu(23, 209));
            board.Add(new Masu(33, 209));
            board.Add(new Masu(43, 209));
            board.Add(new Masu(53, 209));
            board.Add(new Masu(63, 209));
            board.Add(new Masu(73, 209));
            board.Add(new Masu(83, 209));
            board.Add(new Masu(93, 209));

            board.Add(new Masu(14, 0));
            board.Add(new Masu(24, 0));
            board.Add(new Masu(34, 0));
            board.Add(new Masu(44, 0));
            board.Add(new Masu(54, 0));
            board.Add(new Masu(64, 0));
            board.Add(new Masu(74, 0));
            board.Add(new Masu(84, 0));
            board.Add(new Masu(94, 0));

            board.Add(new Masu(15, 0));
            board.Add(new Masu(25, 0));
            board.Add(new Masu(35, 0));
            board.Add(new Masu(45, 0));
            board.Add(new Masu(55, 0));
            board.Add(new Masu(65, 0));
            board.Add(new Masu(75, 0));
            board.Add(new Masu(85, 0));
            board.Add(new Masu(95, 0));

            board.Add(new Masu(16, 0));
            board.Add(new Masu(26, 0));
            board.Add(new Masu(36, 0));
            board.Add(new Masu(46, 0));
            board.Add(new Masu(56, 0));
            board.Add(new Masu(66, 0));
            board.Add(new Masu(76, 0));
            board.Add(new Masu(86, 0));
            board.Add(new Masu(96, 0));

            board.Add(new Masu(17, 109));
            board.Add(new Masu(27, 109));
            board.Add(new Masu(37, 109));
            board.Add(new Masu(47, 109));
            board.Add(new Masu(57, 109));
            board.Add(new Masu(67, 109));
            board.Add(new Masu(77, 109));
            board.Add(new Masu(87, 109));
            board.Add(new Masu(97, 109));

            board.Add(new Masu(18, 0));
            board.Add(new Masu(28, 107));
            board.Add(new Masu(38, 0));
            board.Add(new Masu(48, 0));
            board.Add(new Masu(58, 0));
            board.Add(new Masu(68, 0));
            board.Add(new Masu(78, 0));
            board.Add(new Masu(88, 108));
            board.Add(new Masu(98, 0));

            board.Add(new Masu(19, 106));
            board.Add(new Masu(29, 105));
            board.Add(new Masu(39, 104));
            board.Add(new Masu(49, 103));
            board.Add(new Masu(59, 101));
            board.Add(new Masu(69, 103));
            board.Add(new Masu(79, 104));
            board.Add(new Masu(89, 105));
            board.Add(new Masu(99, 106));
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
