using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_7
{
    public class Triad
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Therd { get; set; }

        public Triad(int first, int second, int therd)
        {
            First = first;
            Second = second;
            Therd = therd;
        }

        public bool Sravnenie(Triad p2)
        {
            if (First > p2.First || (First == p2.First && Second > p2.Second && Therd > p2.Therd)) return true;
            else return false;
        }

        public void SetParams(int first, int second, int therd)
        {
            First = first + 10;
            Second = second + 10;
            Therd = therd + 10;

        }
    }
}

