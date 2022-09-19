using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Lab2FaustWaigandt
{
    abstract class Animal
    {
        public Animal()
        {

        }

        private int[] posicion;
        public int[] Posicion { get { return posicion; } private set { posicion = value; } }


        private bool estaVivo;
        public bool EstaVivo { get { return estaVivo; } }

        

        protected int pasosSinComer;



        public virtual void Mover()
        {

        }

        public abstract void Comer(object comida);


        public void Morir()
        {
            estaVivo = false;
        }
    }
}
