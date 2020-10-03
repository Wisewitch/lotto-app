using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto_app2
{
    class Nyertesszamok
    {
        public int sz1;
        public int sz2;
        public int sz3;
        public int sz4;
        public int sz5;

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
            return this.sz1 + " " + this.sz2 + " " + this.sz3 + " " + this.sz4 + " " + +this.sz5;

        }

    }
}
