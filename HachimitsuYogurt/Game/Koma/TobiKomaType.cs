using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt.Game.Koma
{
    class TobiKomaType : ITobiKoma
    {
        private int code;
        private string name;
        public bool[] movableboard = new bool[81];

        public List<Point> pattern = new List<Point>();
        public List<Point> pattern0 = new List<Point>();
        public List<Point> pattern1 = new List<Point>();
        public List<Point> pattern2 = new List<Point>();
        public List<Point> pattern3 = new List<Point>();

        public TobiKomaType()
        {
        }

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

        public void MovePattern()
        {
        }

        public List<Point> TobiKomaMovePattern()
        {
            List<Point> vector = new List<Point>();

            if (this.GetType() == typeof(Kaku))
            {
                pattern0.Add(new Point(1, 1));
                pattern0.Add(new Point(2, 2));
                pattern0.Add(new Point(3, 3));
                pattern0.Add(new Point(4, 4));
                pattern0.Add(new Point(5, 5));
                pattern0.Add(new Point(6, 6));
                pattern0.Add(new Point(7, 7));
                pattern0.Add(new Point(8, 8));

                pattern1.Add(new Point(1, -1));
                pattern1.Add(new Point(2, -2));
                pattern1.Add(new Point(3, -3));
                pattern1.Add(new Point(4, -4));
                pattern1.Add(new Point(5, -5));
                pattern1.Add(new Point(6, -6));
                pattern1.Add(new Point(7, -7));
                pattern1.Add(new Point(8, -8));

                pattern2.Add(new Point(-1, -1));
                pattern2.Add(new Point(-2, -2));
                pattern2.Add(new Point(-3, -3));
                pattern2.Add(new Point(-4, -4));
                pattern2.Add(new Point(-5, -5));
                pattern2.Add(new Point(-6, -6));
                pattern2.Add(new Point(-7, -7));
                pattern2.Add(new Point(-8, -8));

                pattern3.Add(new Point(-1, 1));
                pattern3.Add(new Point(-2, 2));
                pattern3.Add(new Point(-3, 3));
                pattern3.Add(new Point(-4, 4));
                pattern3.Add(new Point(-5, 5));
                pattern3.Add(new Point(-6, 6));
                pattern3.Add(new Point(-7, 7));
                pattern3.Add(new Point(-8, 8));
            }
            else if (this.GetType() == typeof(Hisha))
            {
                pattern0.Add(new Point(1, 0));
                pattern0.Add(new Point(2, 0));
                pattern0.Add(new Point(3, 0));
                pattern0.Add(new Point(4, 0));
                pattern0.Add(new Point(5, 0));
                pattern0.Add(new Point(6, 0));
                pattern0.Add(new Point(7, 0));
                pattern0.Add(new Point(8, 0));

                pattern1.Add(new Point(0, 1));
                pattern1.Add(new Point(0, 2));
                pattern1.Add(new Point(0, 3));
                pattern1.Add(new Point(0, 4));
                pattern1.Add(new Point(0, 5));
                pattern1.Add(new Point(0, 6));
                pattern1.Add(new Point(0, 7));
                pattern1.Add(new Point(0, 8));

                pattern2.Add(new Point(-1, 0));
                pattern2.Add(new Point(-2, 0));
                pattern2.Add(new Point(-3, 0));
                pattern2.Add(new Point(-4, 0));
                pattern2.Add(new Point(-5, 0));
                pattern2.Add(new Point(-6, 0));
                pattern2.Add(new Point(-7, 0));
                pattern2.Add(new Point(-8, 0));

                pattern3.Add(new Point(0, -1));
                pattern3.Add(new Point(0, -2));
                pattern3.Add(new Point(0, -3));
                pattern3.Add(new Point(0, -4));
                pattern3.Add(new Point(0, -5));
                pattern3.Add(new Point(0, -6));
                pattern3.Add(new Point(0, -7));
                pattern3.Add(new Point(0, -8));
            }
            if (this.GetType() == typeof(Ryuma))
            {
                pattern.Add(new Point(0, 1));
                pattern.Add(new Point(1, 0));
                pattern.Add(new Point(0, -1));
                pattern.Add(new Point(-1, 0));

                pattern0.Add(new Point(1, 1));
                pattern0.Add(new Point(2, 2));
                pattern0.Add(new Point(3, 3));
                pattern0.Add(new Point(4, 4));
                pattern0.Add(new Point(5, 5));
                pattern0.Add(new Point(6, 6));
                pattern0.Add(new Point(7, 7));
                pattern0.Add(new Point(8, 8));

                pattern1.Add(new Point(1, -1));
                pattern1.Add(new Point(2, -2));
                pattern1.Add(new Point(3, -3));
                pattern1.Add(new Point(4, -4));
                pattern1.Add(new Point(5, -5));
                pattern1.Add(new Point(6, -6));
                pattern1.Add(new Point(7, -7));
                pattern1.Add(new Point(8, -8));

                pattern2.Add(new Point(-1, -1));
                pattern2.Add(new Point(-2, -2));
                pattern2.Add(new Point(-3, -3));
                pattern2.Add(new Point(-4, -4));
                pattern2.Add(new Point(-5, -5));
                pattern2.Add(new Point(-6, -6));
                pattern2.Add(new Point(-7, -7));
                pattern2.Add(new Point(-8, -8));

                pattern3.Add(new Point(-1, 1));
                pattern3.Add(new Point(-2, 2));
                pattern3.Add(new Point(-3, 3));
                pattern3.Add(new Point(-4, 4));
                pattern3.Add(new Point(-5, 5));
                pattern3.Add(new Point(-6, 6));
                pattern3.Add(new Point(-7, 7));
                pattern3.Add(new Point(-8, 8));
            }
            else if (this.GetType() == typeof(Ryuou))
            {
                pattern.Add(new Point(1, 1));
                pattern.Add(new Point(1, -1));
                pattern.Add(new Point(-1, -1));
                pattern.Add(new Point(-1, 1));

                pattern0.Add(new Point(1, 0));
                pattern0.Add(new Point(2, 0));
                pattern0.Add(new Point(3, 0));
                pattern0.Add(new Point(4, 0));
                pattern0.Add(new Point(5, 0));
                pattern0.Add(new Point(6, 0));
                pattern0.Add(new Point(7, 0));
                pattern0.Add(new Point(8, 0));

                pattern1.Add(new Point(0, 1));
                pattern1.Add(new Point(0, 2));
                pattern1.Add(new Point(0, 3));
                pattern1.Add(new Point(0, 4));
                pattern1.Add(new Point(0, 5));
                pattern1.Add(new Point(0, 6));
                pattern1.Add(new Point(0, 7));
                pattern1.Add(new Point(0, 8));

                pattern2.Add(new Point(-1, 0));
                pattern2.Add(new Point(-2, 0));
                pattern2.Add(new Point(-3, 0));
                pattern2.Add(new Point(-4, 0));
                pattern2.Add(new Point(-5, 0));
                pattern2.Add(new Point(-6, 0));
                pattern2.Add(new Point(-7, 0));
                pattern2.Add(new Point(-8, 0));

                pattern3.Add(new Point(0, -1));
                pattern3.Add(new Point(0, -2));
                pattern3.Add(new Point(0, -3));
                pattern3.Add(new Point(0, -4));
                pattern3.Add(new Point(0, -5));
                pattern3.Add(new Point(0, -6));
                pattern3.Add(new Point(0, -7));
                pattern3.Add(new Point(0, -8));
            }
            else if (this.GetType() == typeof(Keima))
            {
                pattern.Add(new Point(1, 2));
                pattern.Add(new Point(-1, 2));
            }
            else if (this.GetType() == typeof(Kyousha))
            {
                pattern0.Add(new Point(1, 0));
                pattern0.Add(new Point(2, 0));
                pattern0.Add(new Point(3, 0));
                pattern0.Add(new Point(4, 0));
                pattern0.Add(new Point(5, 0));
                pattern0.Add(new Point(6, 0));
                pattern0.Add(new Point(7, 0));
                pattern0.Add(new Point(8, 0));
            }

            return vector;
        }

        // vector を配列番号に変換
        // 拡張ポイント型に、int (now_state_koma)を挿入
        // now_state_koma に、置きゴマの種類を記録する
        // foreach で、vector をまわして、行き止まりかどうか、指せる手かどうかを判定する

        public List<Point> JudgeGouhoute(bool teban, int pos, Board board)
        {
            List<Point> rtn = new List<Point>();

            var tmp = CalcGouhoute(pattern, teban, pos, board);

            foreach (var s in rtn)
            {
                rtn.Add(s);
            }

            tmp = CalcGouhoute(pattern0, teban, pos, board);

            foreach(var s in rtn)
            {
                rtn.Add(s);
            }

            tmp = CalcGouhoute(pattern1, teban, pos, board);

            foreach (var s in rtn)
            {
                rtn.Add(s);
            }

            tmp = CalcGouhoute(pattern2, teban, pos, board);

            foreach (var s in rtn)
            {
                rtn.Add(s);
            }

            tmp = CalcGouhoute(pattern3, teban, pos, board);

            foreach (var s in rtn)
            {
                rtn.Add(s);
            }

            return rtn;
        }

        private List<Point> CalcGouhoute(List<Point> vector, bool teban, int pos, Board board)
        {
            // 棋譜と配列の使い分け、ぐちゃぐちゃ
            List<PointEx> rtn = new List<PointEx>();

            foreach (var s in vector)
            {
                int x = pos / 10;
                int y = pos % (x * 10);

                //　ここなんか変　y = (y ? (-s.y));
                x = (x + (-s.x));
                y = (y + (-s.y));

                var tmp = ConvertArrayNumber((y * 10) + x);

                if (-1 < tmp && 81 > tmp)
                {
                    if (teban)
                    {
                        rtn.Add(new PointEx(x, y, board.board[tmp].koma_num));
                    }
                    else
                    {
                    }
                }
            }

            bool flag = false;

            List<Point> ret = new List<Point>();

            foreach (var s in rtn)
            {
                if (1 == (s.now_state_koma / 100))
                {
                    flag = true;
                }
                else if (1 == (s.now_state_koma / 200) && flag == false)
                {
                    flag = true;

                    ret.Add(new Point(s.x, s.y));
                }
                else if (1 == (s.now_state_koma / 200) && flag == true)
                {
                    flag = true;
                }

                if (!flag)
                    ret.Add(new Point(s.x, s.y));
            }

            return ret;
        }

        /// <summary>
        /// 移動させようとする駒の位置と駒の移動パターンから、配列インデックスのリストを返す
        /// </summary>
        /// <param name="pos">移動させようとする駒の位置(棋譜形式)</param>
        /// <param name="movablepattern">移動させようとする駒の移動可能位置パターン</param>
        /// <returns>移動可能な配列マス形式のインデックス(配列インデックス形式)</returns>
        /*
        public List<int> MovableKomaMappingBoard(int pos, MovablePattern movablepattern)
        {
            List<Point> movableposition_KIFU = new List<Point>();
            List<int> movableposition_ARRAY = new List<int>();

            // pos から、棋譜上で移動パターンをマッピングする
            foreach (var s in movablepattern.pos)
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

                Console.WriteLine("tmp = " + tmp + ", " + ConvertArrayNumber(tmp));
            }
            return movableposition_ARRAY;
        }
        */

        /// <summary>
        /// 移動させようとする駒の位置と駒の移動パターンから、配列インデックスのリストを返す
        /// </summary>
        /// <param name="pos">移動させようとする駒の位置(棋譜形式)</param>
        /// <param name="movablepattern">移動させようとする駒の移動可能位置パターン</param>
        /// <returns>移動可能な配列マス形式のインデックス(配列インデックス形式)</returns>
        public List<int> MovableKomaMappingBoard(int pos)
        {
            List<Point> movableposition_KIFU = new List<Point>();
            List<int> movableposition_ARRAY = new List<int>();

            // pos から、棋譜上で移動パターンをマッピングする

            // 飛車角は、このルーチンに入らない pattern は空。

            foreach (var s in pattern)
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

            foreach (var s in pattern0)
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

            foreach (var s in pattern1)
            {
                int x = pos / 10;
                int y = pos % (x * 10);

                x = (x + (-s.x));
                y = (y - (-s.y));

                if ((x >= 1 && x <= 9) && (y >= 1 && y <= 9))
                {
                    movableposition_KIFU.Add(new Point(x, y));
                }
            }

            foreach (var s in pattern2)
            {
                int x = pos / 10;
                int y = pos % (x * 10);

                x = (x + (-s.x));
                y = (y - (-s.y));

                if ((x >= 1 && x <= 9) && (y >= 1 && y <= 9))
                {
                    movableposition_KIFU.Add(new Point(x, y));
                }
            }

            foreach (var s in pattern3)
            {
                int x = pos / 10;
                int y = pos % (x * 10);

                x = (x + (-s.x));
                y = (y - (-s.y));

                if ((x >= 1 && x <= 9) && (y >= 1 && y <= 9))
                {
                    movableposition_KIFU.Add(new Point(x, y));
                }
            }

            foreach (var s in movableposition_KIFU)
                Console.WriteLine(s.y.ToString() + s.x.ToString());

            // マッピングパターンを配列番号に変換する
            foreach (var s in movableposition_KIFU)
            {
                int tmp = int.Parse(s.x.ToString()) * 10 + int.Parse(s.y.ToString());

                movableposition_ARRAY.Add(ConvertArrayNumber(tmp));

                Console.WriteLine("tmp = " + tmp + ", " + ConvertArrayNumber(tmp));
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
                            else if (2 == (board.board[i].koma_num / 200))
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
