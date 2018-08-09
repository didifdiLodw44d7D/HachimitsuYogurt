using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt.Game.Koma
{
    class FutsuKomaType
    {
        private int code;
        private string name;
        public bool[] movableboard = new bool[81];

        public List<Point> pattern = new List<Point>();

        public void SetCode(int code)
        {
            this.code = code;
        }

        public int GetCode()
        {
            return code;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public List<Point> MovePattern()
        {
            List<Point> vector = new List<Point>();

            return vector;
        }

        public List<Point> ConvertPoint(int pos)
        {
            List<Point> rtn = new List<Point>();

            switch (pos)
            {
                case 0:
                    rtn.Add(new Point(1, 1));
                    break;
                case 1:
                    rtn.Add(new Point(2, 1));
                    break;
                case 2:
                    rtn.Add(new Point(3, 1));
                    break;
                case 3:
                    rtn.Add(new Point(4, 1));
                    break;
                case 4:
                    rtn.Add(new Point(5, 1));
                    break;
                case 5:
                    rtn.Add(new Point(6, 1));
                    break;
                case 6:
                    rtn.Add(new Point(7, 1));
                    break;
                case 7:
                    rtn.Add(new Point(8, 1));
                    break;
                case 8:
                    rtn.Add(new Point(9, 1));
                    break;
                case 9:
                    rtn.Add(new Point(1, 2));
                    break;
                case 10:
                    rtn.Add(new Point(2, 2));
                    break;
                case 11:
                    rtn.Add(new Point(3, 2));
                    break;
                case 12:
                    rtn.Add(new Point(4, 2));
                    break;
                case 13:
                    rtn.Add(new Point(5, 2));
                    break;
                case 14:
                    rtn.Add(new Point(6, 2));
                    break;
                case 15:
                    rtn.Add(new Point(7, 2));
                    break;
                case 16:
                    rtn.Add(new Point(8, 2));
                    break;
                case 17:
                    rtn.Add(new Point(9, 2));
                    break;
                case 18:
                    rtn.Add(new Point(1, 3));
                    break;
                case 19:
                    rtn.Add(new Point(2, 3));
                    break;
                case 20:
                    rtn.Add(new Point(3, 3));
                    break;
                case 21:
                    rtn.Add(new Point(4, 3));
                    break;
                case 22:
                    rtn.Add(new Point(5, 3));
                    break;
                case 23:
                    rtn.Add(new Point(6, 3));
                    break;
                case 24:
                    rtn.Add(new Point(7, 3));
                    break;
                case 25:
                    rtn.Add(new Point(8, 3));
                    break;
                case 26:
                    rtn.Add(new Point(9, 3));
                    break;
                case 27:
                    rtn.Add(new Point(1, 4));
                    break;
                case 28:
                    rtn.Add(new Point(2, 4));
                    break;
                case 29:
                    rtn.Add(new Point(3, 4));
                    break;
                case 30:
                    rtn.Add(new Point(4, 4));
                    break;
                case 31:
                    rtn.Add(new Point(5, 4));
                    break;
                case 32:
                    rtn.Add(new Point(6, 4));
                    break;
                case 33:
                    rtn.Add(new Point(7, 4));
                    break;
                case 34:
                    rtn.Add(new Point(8, 4));
                    break;
                case 35:
                    rtn.Add(new Point(9, 4));
                    break;
                case 36:
                    rtn.Add(new Point(1, 5));
                    break;
                case 37:
                    rtn.Add(new Point(2, 5));
                    break;
                case 38:
                    rtn.Add(new Point(3, 5));
                    break;
                case 39:
                    rtn.Add(new Point(4, 5));
                    break;
                case 40:
                    rtn.Add(new Point(5, 5));
                    break;
                case 41:
                    rtn.Add(new Point(6, 5));
                    break;
                case 42:
                    rtn.Add(new Point(7, 5));
                    break;
                case 43:
                    rtn.Add(new Point(8, 5));
                    break;
                case 44:
                    rtn.Add(new Point(9, 5));
                    break;
                case 45:
                    rtn.Add(new Point(1, 6));
                    break;
                case 46:
                    rtn.Add(new Point(2, 6));
                    break;
                case 47:
                    rtn.Add(new Point(3, 6));
                    break;
                case 48:
                    rtn.Add(new Point(4, 6));
                    break;
                case 49:
                    rtn.Add(new Point(5, 6));
                    break;
                case 50:
                    rtn.Add(new Point(6, 6));
                    break;
                case 51:
                    rtn.Add(new Point(7, 6));
                    break;
                case 52:
                    rtn.Add(new Point(8, 6));
                    break;
                case 53:
                    rtn.Add(new Point(9, 6));
                    break;
                case 54:
                    rtn.Add(new Point(7, 1));
                    break;
                case 55:
                    rtn.Add(new Point(7, 2));
                    break;
                case 56:
                    rtn.Add(new Point(7, 3));
                    break;
                case 57:
                    rtn.Add(new Point(7, 4));
                    break;
                case 58:
                    rtn.Add(new Point(7, 5));
                    break;
                case 59:
                    rtn.Add(new Point(7, 6));
                    break;
                case 60:
                    rtn.Add(new Point(7, 7));
                    break;
                case 61:
                    rtn.Add(new Point(7, 8));
                    break;
                case 62:
                    rtn.Add(new Point(7, 9));
                    break;
                case 63:
                    rtn.Add(new Point(8, 1));
                    break;
                case 64:
                    rtn.Add(new Point(8, 2));
                    break;
                case 65:
                    rtn.Add(new Point(8, 3));
                    break;
                case 66:
                    rtn.Add(new Point(8, 4));
                    break;
                case 67:
                    rtn.Add(new Point(8, 5));
                    break;
                case 68:
                    rtn.Add(new Point(8, 6));
                    break;
                case 69:
                    rtn.Add(new Point(8, 7));
                    break;
                case 70:
                    rtn.Add(new Point(8, 8));
                    break;
                case 71:
                    rtn.Add(new Point(8, 9));
                    break;
                case 72:
                    rtn.Add(new Point(9, 1));
                    break;
                case 73:
                    rtn.Add(new Point(9, 2));
                    break;
                case 74:
                    rtn.Add(new Point(9, 3));
                    break;
                case 75:
                    rtn.Add(new Point(9, 4));
                    break;
                case 76:
                    rtn.Add(new Point(9, 5));
                    break;
                case 77:
                    rtn.Add(new Point(9, 6));
                    break;
                case 78:
                    rtn.Add(new Point(9, 7));
                    break;
                case 79:
                    rtn.Add(new Point(9, 8));
                    break;
                case 80:
                    rtn.Add(new Point(9, 9));
                    break;                
            }

            return rtn;
        }

        // vector を配列番号に変換
        // 拡張ポイント型に、int (now_state_koma)を挿入
        // now_state_koma に、置きゴマの種類を記録する
        // foreach で、vector をまわして、行き止まりかどうか、指せる手かどうかを判定する

        public List<Point> JudgeGouhoute(bool teban, int pos, List<int> sashite, Board board)
        {
            List<Point> rtn = new List<Point>();

            for (int i = 0; i < 81; i++)
            {
                movableboard[i] = false;

                bool atari = false;

                foreach (var s in sashite)
                {
                    if (i == s)
                    {
                        if (teban)
                        {
                            if (1 == (board.board[i].koma_num / 100))
                            {
                                // 先手番自駒の時は false を返す
                                movableboard[i] = false;
                                atari = true;
                            }
                            else if (1 == (board.board[i].koma_num / 200))
                            {
                                if (atari)
                                {
                                    movableboard[i] = false;
                                }
                                else
                                {
                                    movableboard[i] = true;
                                    atari = true;
                                }
                            }
                            else
                            {
                                if (atari)
                                    movableboard[i] = false;
                                else
                                    movableboard[i] = true;
                            }
                        }
                        else
                        {
                            if (2 == (board.board[i].koma_num / 200))
                            {
                                // 後手番自駒の時は false を返す
                                movableboard[i] = false;
                                atari = true;
                            }
                            else
                            {
                                movableboard[i] = true;
                            }
                        }
                    }
                }
            }

            

            for(int i=0;i<81;i++)
            {
                if(true == movableboard[i])
                {
                    int y = i / 10;

                    if (0 == y)
                        break;

                    int x = i % (y * 10);

                    rtn.Add(new Point(x, y));
                }
            }

            return rtn;
        }

        /// <summary>
        /// 移動させようとする駒の位置と駒の移動パターンから、配列インデックスのリストを返す
        /// </summary>
        /// <param name="pos">移動させようとする駒の位置(棋譜形式)</param>
        /// <param name="movablepattern">移動させようとする駒の移動可能位置パターン</param>
        /// <returns>移動可能な配列マス形式のインデックス(配列インデックス形式)</returns>
        public List<int> MovableKomaMappingBoard(int pos, List<Point> movablepattern)
        {
            List<Point> movableposition_KIFU = new List<Point>();
            List<int> movableposition_ARRAY = new List<int>();

            // pos から、棋譜上で移動パターンをマッピングする
            foreach (var s in movablepattern)
            {
                int x = pos / 10;
                int y = pos % (x * 10);

                x = (x + (-s.x));
                y = (y + (-s.y));

                if ((x >= 1 && x <= 9) && (y >= 1 && y <= 9))
                {
                    movableposition_KIFU.Add(new Point(x, y));
                }
            }

            // マッピングパターンを配列番号に変換する
            foreach (var s in movableposition_KIFU)
            {
                int tmp = int.Parse(s.x.ToString()) * 10 + int.Parse(s.y.ToString());

                movableposition_ARRAY.Add(ConvertArrayNumber(tmp));

                //Console.WriteLine("tmp = " + tmp + ", " + ConvertArrayNumber(tmp));
            }
            return movableposition_ARRAY;
        }

        /// <summary>
        /// 移動させようとする駒が実際に移動可能な位置を検索する
        /// </summary>
        /// <param name="teban">先手[True]/後手[False]</param>
        /// <param name="pos">移動させようとする駒の位置</param>
        /// <param name="sashite">移動パターンの配列インデックス</param>
        /// <param name="board">現在の盤面</param>
        /// <returns>固定長　81bit の bool配列。移動可能な位置を True として返却</returns>
        public bool[] JudgeMovableMasu(bool teban, int pos, List<int> sashite, Board board)
        {
            for (int i = 0; i < 81; i++)
            {
                movableboard[i] = false;

                bool atari = false;
                
                foreach (var s in sashite)
                {
                    if (i == s)
                    {
                        if (teban)
                        {
                            if (1 == (board.board[i].koma_num / 100))
                            {
                                // 先手番自駒の時は false を返す
                                movableboard[i] = false;
                                atari = true;
                            }
                            else if (1 == (board.board[i].koma_num / 200))
                            {
                                if (atari)
                                {
                                    movableboard[i] = false;
                                }
                                else
                                {
                                    movableboard[i] = true;
                                    atari = true;
                                }
                            }
                            else
                            {
                                if (atari)
                                    movableboard[i] = false;
                                else
                                    movableboard[i] = true;
                            }
                        }
                        else
                        {
                            if (2 == (board.board[i].koma_num / 200))
                            {
                                // 後手番自駒の時は false を返す
                                movableboard[i] = false;
                                atari = true;
                            }
                            else
                            {
                                movableboard[i] = true;
                            }
                        }
                    }
                }
            }

            return movableboard;
        }

        public int ConvertArrayNumber(int pos)
        {
            int y = pos / 10;

            if (0 == y)
                return -1;

            int x = pos % (y * 10);

            int arrayformat = 0;

            switch (y)
            {
                case 1:
                    if (x == 1)
                        arrayformat = 0;
                    else if (x == 2)
                        arrayformat = 9;
                    else if (x == 3)
                        arrayformat = 18;
                    else if (x == 4)
                        arrayformat = 27;
                    else if (x == 5)
                        arrayformat = 36;
                    else if (x == 6)
                        arrayformat = 45;
                    else if (x == 7)
                        arrayformat = 54;
                    else if (x == 8)
                        arrayformat = 63;
                    else if (x == 9)
                        arrayformat = 72;
                    break;
                case 2:
                    if (x == 1)
                        arrayformat = 1;
                    else if (x == 2)
                        arrayformat = 10;
                    else if (x == 3)
                        arrayformat = 19;
                    else if (x == 4)
                        arrayformat = 28;
                    else if (x == 5)
                        arrayformat = 37;
                    else if (x == 6)
                        arrayformat = 46;
                    else if (x == 7)
                        arrayformat = 55;
                    else if (x == 8)
                        arrayformat = 64;
                    else if (x == 9)
                        arrayformat = 73;
                    break;
                case 3:
                    if (x == 1)
                        arrayformat = 2;
                    else if (x == 2)
                        arrayformat = 11;
                    else if (x == 3)
                        arrayformat = 20;
                    else if (x == 4)
                        arrayformat = 29;
                    else if (x == 5)
                        arrayformat = 38;
                    else if (x == 6)
                        arrayformat = 47;
                    else if (x == 7)
                        arrayformat = 56;
                    else if (x == 8)
                        arrayformat = 65;
                    else if (x == 9)
                        arrayformat = 74;
                    break;
                case 4:
                    if (x == 1)
                        arrayformat = 3;
                    else if (x == 2)
                        arrayformat = 12;
                    else if (x == 3)
                        arrayformat = 21;
                    else if (x == 4)
                        arrayformat = 30;
                    else if (x == 5)
                        arrayformat = 39;
                    else if (x == 6)
                        arrayformat = 48;
                    else if (x == 7)
                        arrayformat = 57;
                    else if (x == 8)
                        arrayformat = 66;
                    else if (x == 9)
                        arrayformat = 75;
                    break;
                case 5:
                    if (x == 1)
                        arrayformat = 4;
                    else if (x == 2)
                        arrayformat = 13;
                    else if (x == 3)
                        arrayformat = 22;
                    else if (x == 4)
                        arrayformat = 31;
                    else if (x == 5)
                        arrayformat = 40;
                    else if (x == 6)
                        arrayformat = 49;
                    else if (x == 7)
                        arrayformat = 58;
                    else if (x == 8)
                        arrayformat = 67;
                    else if (x == 9)
                        arrayformat = 76;
                    break;
                case 6:
                    if (x == 1)
                        arrayformat = 5;
                    else if (x == 2)
                        arrayformat = 14;
                    else if (x == 3)
                        arrayformat = 23;
                    else if (x == 4)
                        arrayformat = 32;
                    else if (x == 5)
                        arrayformat = 41;
                    else if (x == 6)
                        arrayformat = 50;
                    else if (x == 7)
                        arrayformat = 59;
                    else if (x == 8)
                        arrayformat = 68;
                    else if (x == 9)
                        arrayformat = 77;
                    break;
                case 7:
                    if (x == 1)
                        arrayformat = 6;
                    else if (x == 2)
                        arrayformat = 15;
                    else if (x == 3)
                        arrayformat = 24;
                    else if (x == 4)
                        arrayformat = 33;
                    else if (x == 5)
                        arrayformat = 42;
                    else if (x == 6)
                        arrayformat = 51;
                    else if (x == 7)
                        arrayformat = 60;
                    else if (x == 8)
                        arrayformat = 69;
                    else if (x == 9)
                        arrayformat = 78;
                    break;
                case 8:
                    if (x == 1)
                        arrayformat = 7;
                    else if (x == 2)
                        arrayformat = 16;
                    else if (x == 3)
                        arrayformat = 25;
                    else if (x == 4)
                        arrayformat = 34;
                    else if (x == 5)
                        arrayformat = 43;
                    else if (x == 6)
                        arrayformat = 52;
                    else if (x == 7)
                        arrayformat = 61;
                    else if (x == 8)
                        arrayformat = 70;
                    else if (x == 9)
                        arrayformat = 79;
                    break;
                case 9:
                    if (x == 1)
                        arrayformat = 8;
                    else if (x == 2)
                        arrayformat = 17;
                    else if (x == 3)
                        arrayformat = 26;
                    else if (x == 4)
                        arrayformat = 35;
                    else if (x == 5)
                        arrayformat = 44;
                    else if (x == 6)
                        arrayformat = 53;
                    else if (x == 7)
                        arrayformat = 62;
                    else if (x == 8)
                        arrayformat = 71;
                    else if (x == 9)
                        arrayformat = 80;
                    break;
                default:
                    arrayformat = -1;
                    break;
            }

            return arrayformat;
        }
    }
}
