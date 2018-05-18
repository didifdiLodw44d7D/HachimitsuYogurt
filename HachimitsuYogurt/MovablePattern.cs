using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt
{
    class MovablePattern
    {
        public int koma;
        public List<Point> pos = new List<Point>();

        public List<Point> pattern0 = new List<Point>();
        public List<Point> pattern1 = new List<Point>();
        public List<Point> pattern2 = new List<Point>();
        public List<Point> pattern3 = new List<Point>();

        public void SashitePattern(int koma)
        {
            switch (koma)
            {
                case 101:
                    SetSenteOuPattern(koma);
                    break;
                case 102:
                    SetSenteGyPattern(koma);
                    break;
                case 103:
                    SetSenteKiPattern(koma);
                    break;
                case 104:
                    SetSenteGiPattern(koma);
                    break;
                case 105:
                    SetSenteKePattern(koma);
                    break;
                case 109:
                    SetSenteFuPattern(koma);
                    break;
                case 110:
                    SetSenteNePattern(koma);
                    break;
                case 111:
                    SetSenteNkPattern(koma);
                    break;
                case 112:
                    SetSenteNgPattern(koma);
                    break;
                case 115:
                    SetSenteTkPattern(koma);
                    break;
                case 201:
                    SetGoteOuPattern(koma);
                    break;
                case 202:
                    SetGoteGyPattern(koma);
                    break;
                case 203:
                    SetGoteKiPattern(koma);
                    break;
                case 204:
                    SetGoteGiPattern(koma);
                    break;
                case 205:
                    SetGoteKePattern(koma);
                    break;
                case 209:
                    SetGoteFuPattern(koma);
                    break;
                case 210:
                    SetGoteNePattern(koma);
                    break;
                case 211:
                    SetGoteNkPattern(koma);
                    break;
                case 212:
                    SetGoteNgPattern(koma);
                    break;
                case 215:
                    SetGoteTkPattern(koma);
                    break;

            }
        }

        public bool[] SashitePattern(int koma, bool teban, int kifu_pos, Board board)
        {
            bool[] rtn = new bool[81];

            switch (koma)
            {
                case 106:
                    SetSenteKyPattern(koma, teban, kifu_pos, board);
                    break;
                case 107:
                    SetSenteHiPattern(koma, teban, kifu_pos, board);
                    break;
                case 108:
                    rtn = SetSenteKaPattern(koma, teban, kifu_pos, board);
                    break;
                case 113:
                    SetSenteRyPattern(koma, teban, kifu_pos, board);
                    break;
                case 114:
                    SetSenteRmPattern(koma, teban, kifu_pos, board);
                    break;
                case 206:
                    SetGoteKyPattern(koma, teban, kifu_pos, board);
                    break;
                case 207:
                    SetGoteHiPattern(koma, teban, kifu_pos, board);
                    break;
                case 208:
                    SetGoteKaPattern(koma, teban, kifu_pos, board);
                    break;
                case 213:
                    SetGoteRyPattern(koma, teban, kifu_pos, board);
                    break;
                case 214:
                    SetGoteRmPattern(koma, teban, kifu_pos, board);
                    break;
            }

            return rtn;
        }

        //"SENTE-OU"
        public void SetSenteOuPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, 1));
        }

        //"SENTE-GY"
        public void SetSenteGyPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, 1));
        }

        //"SENTE-KI"
        public void SetSenteKiPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, 1));
        }

        //"SENTE-GI"
        public void SetSenteGiPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 1));

            foreach (var s in pos)
                Console.WriteLine(s.x + ", " + s.y);
        }

        //"SENTE-KE"
        public void SetSenteKePattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(1, 3));
            pos.Add(new Point(-1, 3));
        }

        //"SENTE-KY"
        public void SetSenteKyPattern(int koma, bool teban, int kifu_pos, Board board)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(0, 2));
            pos.Add(new Point(0, 3));
            pos.Add(new Point(0, 4));
            pos.Add(new Point(0, 5));
            pos.Add(new Point(0, 6));
            pos.Add(new Point(0, 7));
            pos.Add(new Point(0, 8));
        }

        //"SENTE-HI"
        public void SetSenteHiPattern(int koma, bool teban, int kifu_pos, Board board)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, 0));
            
            pos.Add(new Point(0, 2));
            pos.Add(new Point(0, -2));
            
            pos.Add(new Point(0, 3));
            pos.Add(new Point(0, -3));
            
            pos.Add(new Point(0, 4));
            pos.Add(new Point(0, -4));
            
            pos.Add(new Point(0, 5));
            pos.Add(new Point(0, -5));

            pos.Add(new Point(0, 6));
            pos.Add(new Point(0, -6));

            pos.Add(new Point(0, 7));
            pos.Add(new Point(0, -7));

            pos.Add(new Point(0, 8));
            pos.Add(new Point(0, -8));

            pos.Add(new Point(2, 0));
            pos.Add(new Point(-2, 0));

            pos.Add(new Point(3, 0));
            pos.Add(new Point(-3, 0));

            pos.Add(new Point(4, 0));
            pos.Add(new Point(-4, 0));

            pos.Add(new Point(5, 0));
            pos.Add(new Point(-5, 0));

            pos.Add(new Point(6, 0));
            pos.Add(new Point(-6, 0));

            pos.Add(new Point(7, 0));
            pos.Add(new Point(-7, 0));

            pos.Add(new Point(8, 0));
            pos.Add(new Point(-8, 0));
        }

        //"SENTE-KA"
        public bool[] SetSenteKaPattern(int koma, bool teban, int kifu_pos, Board board)
        {
            this.koma = koma;

            pattern0 = SearchPositionVector("right-up", teban, kifu_pos, board);
            pattern1 = SearchPositionVector("right-down", teban, kifu_pos, board);
            pattern2 = SearchPositionVector("left-down", teban, kifu_pos, board);
            pattern3 = SearchPositionVector("left-up", teban, kifu_pos, board);

            foreach (var s in pattern0)
                Console.WriteLine("Pattern0 = ({0},{1})", s.x, s.y);

            foreach (var s in pattern1)
                Console.WriteLine("Pattern1 = ({0},{1})", s.x, s.y);

            foreach (var s in pattern2)
                Console.WriteLine("Pattern2 = ({0},{1})", s.x, s.y);

            foreach (var s in pattern3)
                Console.WriteLine("Pattern3 = ({0},{1})", s.x, s.y);
            
            // 配列にマッピング

            var reg = new Regulation();

            //var mappingarray = reg.MovableKomaMappingBoard(kifu_pos, this, 0);

            List<int> mappingarray = new List<int>();

            foreach (var s in pattern0)
                mappingarray.Add((s.y * 10) + s.x);

            foreach (var s in pattern1)
                mappingarray.Add((s.y * 10) + s.x);

            foreach (var s in pattern2)
                mappingarray.Add((s.y * 10) + s.x);

            foreach (var s in pattern3)
                mappingarray.Add((s.y * 10) + s.x);


            foreach (var s in mappingarray)
                Console.WriteLine("mappingarray = " + s);

            // おける場所かどうかの判断

            var snapshot = reg.JudgeMovableMasu(true, kifu_pos, mappingarray, board);

            return snapshot;
        }

        //"SENTE-FU"
        public void SetSenteFuPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(1, 0));
        }

        //"SENTE-NE"
        public void SetSenteNePattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, 1));
        }

        //"SENTE-NK"
        public void SetSenteNkPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, 1));
        }

        //"SENTE-NG"
        public void SetSenteNgPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, 1));
        }

        //"SENTE-RY"
        public void SetSenteRyPattern(int koma, bool teban, int kifu_pos, Board board)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(-1, 1));

            pos.Add(new Point(0, 2));
            pos.Add(new Point(2, 0));
            pos.Add(new Point(0, -2));
            pos.Add(new Point(-2, 0));

            pos.Add(new Point(0, 3));
            pos.Add(new Point(3, 0));
            pos.Add(new Point(0, -3));
            pos.Add(new Point(-3, 0));

            pos.Add(new Point(0, 4));
            pos.Add(new Point(4, 0));
            pos.Add(new Point(0, -4));
            pos.Add(new Point(-4, 0));

            pos.Add(new Point(0, 5));
            pos.Add(new Point(5, 0));
            pos.Add(new Point(0, -5));
            pos.Add(new Point(-5, 0));

            pos.Add(new Point(0, 6));
            pos.Add(new Point(6, 0));
            pos.Add(new Point(0, -6));
            pos.Add(new Point(-6, 0));

            pos.Add(new Point(0, 7));
            pos.Add(new Point(7, 0));
            pos.Add(new Point(0, -7));
            pos.Add(new Point(-7, 0));

            pos.Add(new Point(0, 8));
            pos.Add(new Point(8, 0));
            pos.Add(new Point(0, -8));
            pos.Add(new Point(-8, 0));
        }

        //"SENTE-RM"
        public void SetSenteRmPattern(int koma, bool teban, int kifu_pos, Board board)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, 1));

            pos.Add(new Point(2, 2));
            pos.Add(new Point(2, -2));
            pos.Add(new Point(-2, -2));
            pos.Add(new Point(-2, 2));

            pos.Add(new Point(3, 3));
            pos.Add(new Point(3, -3));
            pos.Add(new Point(-3, -3));
            pos.Add(new Point(-3, 3));

            pos.Add(new Point(4, 4));
            pos.Add(new Point(4, -4));
            pos.Add(new Point(-4, -4));
            pos.Add(new Point(-4, 4));

            pos.Add(new Point(5, 5));
            pos.Add(new Point(5, -5));
            pos.Add(new Point(-5, -5));
            pos.Add(new Point(-5, 5));

            pos.Add(new Point(6, 6));
            pos.Add(new Point(6, -6));
            pos.Add(new Point(-6, -6));
            pos.Add(new Point(-6, 6));

            pos.Add(new Point(7, 7));
            pos.Add(new Point(7, -7));
            pos.Add(new Point(-7, -7));
            pos.Add(new Point(-7, 7));

            pos.Add(new Point(8, 8));
            pos.Add(new Point(8, -8));
            pos.Add(new Point(-8, -8));
            pos.Add(new Point(-8, 8));
        }

        //"SENTE-TK"
        public void SetSenteTkPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, -1));
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, 1));
        }

        //"GOTE-OU"
        public void SetGoteOuPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(-1, 1));
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, 1));
        }

        //"GOTE-GY"
        public void SetGoteGyPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(-1, 1));
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, 1));
        }

        //"GOTE-KI"
        public void SetGoteKiPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, 1));
        }

        //"GOTE-GI"
        public void SetGoteGiPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, -1));
        }

        //"GOTE-KE"
        public void SetGoteKePattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(1, -3));
            pos.Add(new Point(-1, -3));
        }

        //"GOTE-KY"
        public void SetGoteKyPattern(int koma, bool teban, int kifu_pos, Board board)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(0, -2));
            pos.Add(new Point(0, -3));
            pos.Add(new Point(0, -4));
            pos.Add(new Point(0, -5));
            pos.Add(new Point(0, -6));
            pos.Add(new Point(0, -7));
            pos.Add(new Point(0, -8));
        }

        //"GOTE-HI"
        public void SetGoteHiPattern(int koma, bool teban, int kifu_pos, Board board)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 0));

            pos.Add(new Point(0, -2));
            pos.Add(new Point(-2, 0));
            pos.Add(new Point(0, 2));
            pos.Add(new Point(2, 0));

            pos.Add(new Point(0, -3));
            pos.Add(new Point(-3, 0));
            pos.Add(new Point(0, 3));
            pos.Add(new Point(3, 0));

            pos.Add(new Point(0, -4));
            pos.Add(new Point(-4, 0));
            pos.Add(new Point(0, 4));
            pos.Add(new Point(4, 0));

            pos.Add(new Point(0, -5));
            pos.Add(new Point(-5, 0));
            pos.Add(new Point(0, 5));
            pos.Add(new Point(5, 0));

            pos.Add(new Point(0, -6));
            pos.Add(new Point(-6, 0));
            pos.Add(new Point(0, 6));
            pos.Add(new Point(6, 0));

            pos.Add(new Point(0, -7));
            pos.Add(new Point(-7, 0));
            pos.Add(new Point(0, 7));
            pos.Add(new Point(7, 0));

            pos.Add(new Point(0, -8));
            pos.Add(new Point(-8, 0));
            pos.Add(new Point(0, 8));
            pos.Add(new Point(8, 0));
        }

        //"GOTE-KA"
        public void SetGoteKaPattern(int koma, bool teban, int kifu_pos, Board board)
        {
            this.koma = koma;
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, -1));

            pos.Add(new Point(-2, -2));
            pos.Add(new Point(-2, 2));
            pos.Add(new Point(2, 2));
            pos.Add(new Point(2, -2));

            pos.Add(new Point(-3, -3));
            pos.Add(new Point(-3, 3));
            pos.Add(new Point(3, 3));
            pos.Add(new Point(3, -3));

            pos.Add(new Point(-4, -4));
            pos.Add(new Point(-4, 4));
            pos.Add(new Point(4, 4));
            pos.Add(new Point(4, -4));

            pos.Add(new Point(-5, -5));
            pos.Add(new Point(-5, 5));
            pos.Add(new Point(5, 5));
            pos.Add(new Point(5, -5));

            pos.Add(new Point(-6, -6));
            pos.Add(new Point(-6, 6));
            pos.Add(new Point(6, 6));
            pos.Add(new Point(6, -6));

            pos.Add(new Point(-7, -7));
            pos.Add(new Point(-7, 7));
            pos.Add(new Point(7, 7));
            pos.Add(new Point(7, -7));

            pos.Add(new Point(-8, -8));
            pos.Add(new Point(-8, 8));
            pos.Add(new Point(8, 8));
            pos.Add(new Point(8, -8));
        }

        //"GOTE-FU"
        public void SetGoteFuPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
        }

        //"GOTE-NE"
        public void SetGoteNePattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, 1));
        }

        //"GOTE-NK"
        public void SetGoteNkPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, 1));
        }

        //"GOTE-NG"
        public void SetGoteNgPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, 1));
        }

        //"GOTE-RY"
        public void SetGoteRyPattern(int koma, bool teban, int kifu_pos, Board board)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(-1, 1));
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, -1));

            pos.Add(new Point(0, -2));
            pos.Add(new Point(-2, 0));
            pos.Add(new Point(0, 2));
            pos.Add(new Point(2, 0));

            pos.Add(new Point(0, -3));
            pos.Add(new Point(-3, 0));
            pos.Add(new Point(0, 3));
            pos.Add(new Point(3, 0));

            pos.Add(new Point(0, -4));
            pos.Add(new Point(-4, 0));
            pos.Add(new Point(0, 4));
            pos.Add(new Point(4, 0));

            pos.Add(new Point(0, -5));
            pos.Add(new Point(-5, 0));
            pos.Add(new Point(0, 5));
            pos.Add(new Point(5, 0));

            pos.Add(new Point(0, -6));
            pos.Add(new Point(-6, 0));
            pos.Add(new Point(0, 6));
            pos.Add(new Point(6, 0));

            pos.Add(new Point(0, -7));
            pos.Add(new Point(-7, 0));
            pos.Add(new Point(0, 7));
            pos.Add(new Point(7, 0));

            pos.Add(new Point(0, -8));
            pos.Add(new Point(-8, 0));
            pos.Add(new Point(0, 8));
            pos.Add(new Point(8, 0));
        }

        //"GOTE-RM"
        public void SetGoteRmPattern(int koma, bool teban, int kifu_pos, Board board)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(-1, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, 1));
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, -1));

            pos.Add(new Point(-2, -2));
            pos.Add(new Point(-2, 2));
            pos.Add(new Point(2, 2));
            pos.Add(new Point(2, -2));

            pos.Add(new Point(-3, -3));
            pos.Add(new Point(-3, 3));
            pos.Add(new Point(3, 3));
            pos.Add(new Point(3, -3));

            pos.Add(new Point(-4, -4));
            pos.Add(new Point(-4, 4));
            pos.Add(new Point(4, 4));
            pos.Add(new Point(4, -4));

            pos.Add(new Point(-5, -5));
            pos.Add(new Point(-5, 5));
            pos.Add(new Point(5, 5));
            pos.Add(new Point(5, -5));

            pos.Add(new Point(-6, -6));
            pos.Add(new Point(-6, 6));
            pos.Add(new Point(6, 6));
            pos.Add(new Point(6, -6));

            pos.Add(new Point(-7, -7));
            pos.Add(new Point(-7, 7));
            pos.Add(new Point(7, 7));
            pos.Add(new Point(7, -7));

            pos.Add(new Point(-8, -8));
            pos.Add(new Point(-8, 8));
            pos.Add(new Point(8, 8));
            pos.Add(new Point(8, -8));
        }

        //"GOTE-TK"
        public void SetGoteTkPattern(int koma)
        {
            this.koma = koma;
            pos.Add(new Point(0, -1));
            pos.Add(new Point(-1, -1));
            pos.Add(new Point(-1, 0));
            pos.Add(new Point(0, 1));
            pos.Add(new Point(1, 0));
            pos.Add(new Point(1, 1));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public List<Point> SearchPositionVector(string pattern, bool teban, int pos, Board board)
        {
            List<Point> vector = new List<Point>();

            // 角・竜馬
            if ("right-up" == pattern)
            {
                vector.Add(new Point(1, 1));
                vector.Add(new Point(2, 2));
                vector.Add(new Point(3, 3));
                vector.Add(new Point(4, 4));
                vector.Add(new Point(5, 5));
                vector.Add(new Point(6, 6));
                vector.Add(new Point(7, 7));
                vector.Add(new Point(8, 8));
            }
            if ("right-down" == pattern)
            {
                vector.Add(new Point(1, -1));
                vector.Add(new Point(2, -2));
                vector.Add(new Point(3, -3));
                vector.Add(new Point(4, -4));
                vector.Add(new Point(5, -5));
                vector.Add(new Point(6, -6));
                vector.Add(new Point(7, -7));
                vector.Add(new Point(8, -8));
            }
            if ("left-down" == pattern)
            {
                vector.Add(new Point(-1, -1));
                vector.Add(new Point(-2, -2));
                vector.Add(new Point(-3, -3));
                vector.Add(new Point(-4, -4));
                vector.Add(new Point(-5, -5));
                vector.Add(new Point(-6, -6));
                vector.Add(new Point(-7, -7));
                vector.Add(new Point(-8, -8));
            }
            if ("left-up" == pattern)
            {
                vector.Add(new Point(-1, 1));
                vector.Add(new Point(-2, 2));
                vector.Add(new Point(-3, 3));
                vector.Add(new Point(-4, 4));
                vector.Add(new Point(-5, 5));
                vector.Add(new Point(-6, 6));
                vector.Add(new Point(-7, 7));
                vector.Add(new Point(-8, 8));
            }

            // 飛車・竜王
            if ("up" == pattern)
            {
                vector.Add(new Point(0, 1));
                vector.Add(new Point(0, 2));
                vector.Add(new Point(0, 3));
                vector.Add(new Point(0, 4));
                vector.Add(new Point(0, 5));
                vector.Add(new Point(0, 6));
                vector.Add(new Point(0, 7));
                vector.Add(new Point(0, 8));
            }
            if ("right" == pattern)
            {
                vector.Add(new Point(1, 0));
                vector.Add(new Point(2, 0));
                vector.Add(new Point(3, 0));
                vector.Add(new Point(4, 0));
                vector.Add(new Point(5, 0));
                vector.Add(new Point(6, 0));
                vector.Add(new Point(7, 0));
                vector.Add(new Point(8, 0));
            }
            if ("down" == pattern)
            {
                vector.Add(new Point(0, -1));
                vector.Add(new Point(0, -2));
                vector.Add(new Point(0, -3));
                vector.Add(new Point(0, -4));
                vector.Add(new Point(0, -5));
                vector.Add(new Point(0, -6));
                vector.Add(new Point(0, -7));
                vector.Add(new Point(0, -8));
            }
            if ("left" == pattern)
            {
                vector.Add(new Point(-1, 0));
                vector.Add(new Point(-2, 0));
                vector.Add(new Point(-3, 0));
                vector.Add(new Point(-4, 0));
                vector.Add(new Point(-5, 0));
                vector.Add(new Point(-6, 0));
                vector.Add(new Point(-7, 0));
                vector.Add(new Point(-8, 0));
            }

            var rtn = JudgeGouhoute(vector, teban, pos, board);

            return rtn;
        }

        // vector を配列番号に変換
        // 拡張ポイント型に、int (now_state_koma)を挿入
        // now_state_koma に、置きゴマの種類を記録する
        // foreach で、vector をまわして、行き止まりかどうか、指せる手かどうかを判定する

        public List<Point> JudgeGouhoute(List<Point> vector, bool teban, int pos, Board board)
        {
            // 棋譜と配列の使い分け、ぐちゃぐちゃ
            List<PointEx> rtn = new List<PointEx>();

            foreach (var s in vector)
            {
                int x = pos / 10;
                int y = pos % (x * 10);

                //　ここなんか変　y = (y ? (-s.y));
                x = (x + (-s.x));
                y = (y - (-s.y));

                Regulation reg = new Regulation();

                var tmp = reg.ConvertArrayNumber((y * 10) + x);

                Console.WriteLine("{0} - {1}", ((y * 10) + x), tmp);

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
                if(1 == (s.now_state_koma / 100))
                {
                    flag = true;
                }
                else if(1 == (s.now_state_koma / 200) && flag == false)
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
    }
}
