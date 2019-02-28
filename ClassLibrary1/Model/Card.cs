using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    public enum mast { chervi, trefy, bubi, piki }
    public enum naminal { six = 6, seven = 7, eight = 8, nine = 9, ten = 10, valet = 11, dama = 12, korol = 13, tyz = 14 };
   public  class Kart
    {
        public mast Mast { get; set; }
        public naminal Naminal { get; set; }
        public void printInfo()
        {
            Console.Write("{0}, {1}\t", Mast, Naminal);
        }

    }
}
