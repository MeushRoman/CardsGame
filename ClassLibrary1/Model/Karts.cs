using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    public abstract class Karts
    {

        public List<Kart> karts { get; set; }
        public virtual void Create()
        {
            foreach (mast m in (mast[])Enum.GetValues(typeof(mast)))
            {
                foreach (var n in (naminal[])Enum.GetValues(typeof(naminal)))
                {
                    karts.Add(new Kart() { Mast = m, Naminal = n });
                }
            }
        }

        public virtual Shuffle()
        {

        }
        public void print()
        {
            foreach (Kart item in karts)
            {

            }
        }
    }
}
