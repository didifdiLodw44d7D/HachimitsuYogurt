using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt
{
    class Board
    {
        public List<Masu> board = new List<Masu>();
        public KomaType type = new KomaType();
 
        public Board()
        {
            board.Add(new Masu(11, type.koma["GOTE-KY"]));
            board.Add(new Masu(21, type.koma["GOTE-KE"]));
            board.Add(new Masu(31, type.koma["GOTE-GI"]));
            board.Add(new Masu(41, type.koma["GOTE-KI"]));
            board.Add(new Masu(51, type.koma["GOTE-GY"]));
            board.Add(new Masu(61, type.koma["GOTE-KI"]));
            board.Add(new Masu(71, type.koma["GOTE-GI"]));
            board.Add(new Masu(81, type.koma["GOTE-KE"]));
            board.Add(new Masu(91, type.koma["GOTE-KY"]));

            board.Add(new Masu(12, type.koma["NULL"]));
            board.Add(new Masu(22, type.koma["GOTE-KA"]));
            board.Add(new Masu(32, type.koma["NULL"]));
            board.Add(new Masu(42, type.koma["NULL"]));
            board.Add(new Masu(52, type.koma["NULL"]));
            board.Add(new Masu(62, type.koma["NULL"]));
            board.Add(new Masu(72, type.koma["NULL"]));
            board.Add(new Masu(82, type.koma["GOTE-HI"]));
            board.Add(new Masu(92, type.koma["NULL"]));

            board.Add(new Masu(13, type.koma["GOTE-FU"]));
            board.Add(new Masu(23, type.koma["GOTE-FU"]));
            board.Add(new Masu(33, type.koma["GOTE-FU"]));
            board.Add(new Masu(43, type.koma["GOTE-FU"]));
            board.Add(new Masu(53, type.koma["GOTE-FU"]));
            board.Add(new Masu(63, type.koma["GOTE-FU"]));
            board.Add(new Masu(73, type.koma["GOTE-FU"]));
            board.Add(new Masu(83, type.koma["GOTE-FU"]));
            board.Add(new Masu(93, type.koma["GOTE-FU"]));

            board.Add(new Masu(14, type.koma["NULL"]));
            board.Add(new Masu(24, type.koma["NULL"]));
            board.Add(new Masu(34, type.koma["NULL"]));
            board.Add(new Masu(44, type.koma["NULL"]));
            board.Add(new Masu(54, type.koma["NULL"]));
            board.Add(new Masu(64, type.koma["NULL"]));
            board.Add(new Masu(74, type.koma["NULL"]));
            board.Add(new Masu(84, type.koma["NULL"]));
            board.Add(new Masu(94, type.koma["NULL"]));

            board.Add(new Masu(15, type.koma["NULL"]));
            board.Add(new Masu(25, type.koma["NULL"]));
            board.Add(new Masu(35, type.koma["NULL"]));
            board.Add(new Masu(45, type.koma["NULL"]));
            board.Add(new Masu(55, type.koma["NULL"]));
            board.Add(new Masu(65, type.koma["NULL"]));
            board.Add(new Masu(75, type.koma["NULL"]));
            board.Add(new Masu(85, type.koma["NULL"]));
            board.Add(new Masu(95, type.koma["NULL"]));

            board.Add(new Masu(16, type.koma["NULL"]));
            board.Add(new Masu(26, type.koma["NULL"]));
            board.Add(new Masu(36, type.koma["NULL"]));
            board.Add(new Masu(46, type.koma["NULL"]));
            board.Add(new Masu(56, type.koma["NULL"]));
            board.Add(new Masu(66, type.koma["NULL"]));
            board.Add(new Masu(76, type.koma["NULL"]));
            board.Add(new Masu(86, type.koma["NULL"]));
            board.Add(new Masu(96, type.koma["NULL"]));

            board.Add(new Masu(17, type.koma["SENTE-FU"]));
            board.Add(new Masu(27, type.koma["SENTE-FU"]));
            board.Add(new Masu(37, type.koma["SENTE-FU"]));
            board.Add(new Masu(47, type.koma["SENTE-FU"]));
            board.Add(new Masu(57, type.koma["SENTE-FU"]));
            board.Add(new Masu(67, type.koma["SENTE-FU"]));
            board.Add(new Masu(77, type.koma["SENTE-FU"]));
            board.Add(new Masu(87, type.koma["SENTE-FU"]));
            board.Add(new Masu(97, type.koma["SENTE-FU"]));

            board.Add(new Masu(18, type.koma["NULL"]));
            board.Add(new Masu(28, type.koma["SENTE-HI"]));
            board.Add(new Masu(38, type.koma["NULL"]));
            board.Add(new Masu(48, type.koma["NULL"]));
            board.Add(new Masu(58, type.koma["NULL"]));
            board.Add(new Masu(68, type.koma["NULL"]));
            board.Add(new Masu(78, type.koma["NULL"]));
            board.Add(new Masu(88, type.koma["SENTE-KA"]));
            board.Add(new Masu(98, type.koma["NULL"]));

            board.Add(new Masu(19, type.koma["SENTE-KY"]));
            board.Add(new Masu(29, type.koma["SENTE-KE"]));
            board.Add(new Masu(39, type.koma["SENTE-GI"]));
            board.Add(new Masu(49, type.koma["SENTE-KI"]));
            board.Add(new Masu(59, type.koma["SENTE-OU"]));
            board.Add(new Masu(69, type.koma["SENTE-KI"]));
            board.Add(new Masu(79, type.koma["SENTE-GI"]));
            board.Add(new Masu(89, type.koma["SENTE-KE"]));
            board.Add(new Masu(99, type.koma["SENTE-KY"]));
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
