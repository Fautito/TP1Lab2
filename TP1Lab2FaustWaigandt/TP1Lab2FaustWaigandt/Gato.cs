using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Lab2FaustWaigandt
{
    class Gato : Animal
    {
        public override void Comer(object comida)
        {
            if(comida is Raton)
            {
                ((Raton)comida).Morir();
                this.pasosSinComer = 0;
            }
        }
    }
}
