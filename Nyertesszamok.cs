using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto_app
{
    class Nyertesszamok
    {
        private int sz1;
        private int sz2;
        private int sz3;
        private int sz4;
        private int sz5;

        public int Sz1 { get => sz1; set => sz1 = value; }
        public int Sz2 { get => sz2; set => sz2 = value; }
        public int Sz3 { get => sz3; set => sz3 = value; }
        public int Sz4 { get => sz4; set => sz4 = value; }
        public int Sz5 { get => sz5; set => sz5 = value; }

        public Nyertesszamok(int sz1, int sz2, int sz3, int sz4, int sz5)
        {
            this.sz1 = sz1;
            this.sz2 = sz2;
            this.sz3 = sz3;
            this.sz4 = sz4;
            this.sz5 = sz5;
        }

        public override string ToString()
        {
            return Convert.ToInt32(sz1) + " " + Convert.ToInt32(sz2) + " " + Convert.ToInt32(sz3) + " "
                + Convert.ToInt32(sz4) + " " + Convert.ToInt32(sz5);

        }

        public string Kiirias()
        {
            return sz1 + ", " + sz2 + ", " + sz3 + ", " + sz4 + ", " + sz5;
        }

    }
}
