using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Lab2FaustWaigandt
{
    class Gato : Animal
    {
        public Gato(Isla isla) : base(isla) { }
        
        public override void Comer(object comida)
        {
            if(comida is Raton)
            {
                ((Raton)comida).Morir();
                this.pasosSinComer = 0;
            }
        }

        public override void Mover()
        {
            base.Mover();//toma la isla heredada de animal, mueves con los random, pregunta si esta en el borde mediante los indices, si no lo esta, mueve normalmente, si se acerca a los border hay  que restar numeros al movimiento
        }
    }
}
