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
                this.diasSinComer = 0;
            }
        }


        public override void SumarDia()
        {
            base.SumarDia();
            if (this.diasSinComer > 4) this.Morir();
        }


        public override void Mover()
        {
            base.Mover();
            if (this.Posicion[0] >= i.Dimensiones[0]) { this.Posicion[0] = i.Dimensiones[0]-1; }
            else if (this.Posicion[0] < 0) { this.Posicion[0] = 0; }
            if (this.Posicion[1] >= i.Dimensiones[1]) { this.Posicion[1] = i.Dimensiones[1]-1; }
            else if (this.Posicion[1] < 0) { this.Posicion[1] = 0; }
        }



        public override string ToString()
        {
            return $"Gato,  Posicion {Posicion[0]} - {Posicion[1]}, Comio hace {diasSinComer} dias, lleva {diasVividos} dias vivo";
        }
    }
}
