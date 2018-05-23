using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachimitsuYogurt.Game.Koma
{
    class FutsuKomaType
    {
        /*
        public const string Null = "NULL";

        public const string sente_OU = "SENTE-OU";
        public const string sente_GY = "SENTE-GY";
        public const string sente_KI = "SENTE-KI";
        public const string sente_GI = "SENTE-GI";
        public const string sente_KE = "SENTE-KE";
        public const string sente_KY = "SENTE-KY";
        public const string sente_HI = "SENTE-HI";
        public const string sente_KA = "SENTE-KA";
        public const string sente_FU = "SENTE-FU";
        public const string sente_NE = "SENTE-NE";
        public const string sente_NK = "SENTE-NK";
        public const string sente_NG = "SENTE-NG";
        public const string sente_RY = "SENTE-RY";
        public const string sente_RM = "SENTE-RM";
        public const string sente_TK = "SENTE-TK";

        public const string gote_OU = "GOTE-OU";
        public const string gote_GY = "GOTE-GY";
        public const string gote_KI = "GOTE-KI";
        public const string gote_GI = "GOTE-GI";
        public const string gote_KE = "GOTE-KE";
        public const string gote_KY = "GOTE-KY";
        public const string gote_HI = "GOTE-HI";
        public const string gote_KA = "GOTE-KA";
        public const string gote_FU = "GOTE-FU";
        public const string gote_NE = "GOTE-NE";
        public const string gote_NK = "GOTE-NK";
        public const string gote_NG = "GOTE-NG";
        public const string gote_RY = "GOTE-RY";
        public const string gote_RM = "GOTE-RM";
        public const string gote_TK = "GOTE-TK";

        public Dictionary<string, int> koma = new Dictionary<string, int>(31);

        public KomaType()
        {
            koma.Add(Null, 0);

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

        private int code;
        private string name;
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

        public void MovePattern()
        {
        }

        public void TobiKomaMovePattern()
        {

        }
    }
}
