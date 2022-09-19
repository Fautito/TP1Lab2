using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Lab2FaustWaigandt
{
    class Raton : Animal
    {
        public Raton(Isla i) : base(i) { }
        public override void Comer(object comida)
        {
            if(comida is Queso)
            {
                ((Queso)comida).SerComido();
                this.pasosSinComer = 0;
            }
        }


        
    }
}
