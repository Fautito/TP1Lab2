using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Lab2FaustWaigandt
{
    class Raton : Animal
    {
        private int comioHoy;

        private bool genero;
        public bool Genero
        {
            get { return genero; }
            private set { genero = value; }
        }


        public Raton(Isla i) : base(i) {
            this.comioHoy = 0;
            this.genero= Convert.ToBoolean(rnd.Next(2));

        }


        public override void Comer(object comida)
        {
            if(comida is Queso && comioHoy<2 && ((Queso)comida).Porciones>0)
            {
                ((Queso)comida).SerComido();
                this.comioHoy++;
                this.diasSinComer = 0;
            }
        }


        
        public override void SumarDia()
        {
            base.SumarDia();
            comioHoy = 0;
            if (this.diasSinComer > 2) this.Morir();
        }



        public override void Mover()
        {
            base.Mover();
            if (this.Posicion[0] >= i.Dimensiones[0] || this.Posicion[0] < 0) this.Morir();
            
            if (this.Posicion[1] >= i.Dimensiones[1] || this.Posicion[1] < 0) this.Morir();
            
        }

        public override string ToString()
        {
            string g = Genero ? "Macho" : "Hembra";
            return $"Raton { g} Posicion {Posicion[0]} - {Posicion[1]}, Comio hace {diasSinComer} dias, lleva { diasVividos} dias vivo";
        }
    }
}
