using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Lab2FaustWaigandt
{
    abstract class Animal:IPosicionable
    {
        static protected Random rnd = new Random();
        public Animal(Isla isla)
        {
            this.i = isla;
            this.Posicion = new int[] { rnd.Next(isla.Dimensiones[0]), rnd.Next(isla.Dimensiones[1]) };
            diasSinComer = 0;
            diasVividos = 0;
            estaVivo = true;
        }


        protected Isla i;

        private int[] posicion;
        public int[] Posicion 
        { 
            get { return posicion; } 
            set { posicion = value; } 
        }


        private bool estaVivo;
        public bool EstaVivo 
        { 
            get { return estaVivo; } 
            set { estaVivo = value; }
        }


        protected int diasVividos;
        protected int diasSinComer;

        virtual public void SumarDia() 
        {
            this.diasSinComer++;
            this.diasVividos++;
        }
        
        public virtual void Mover()
        {

            if (rnd.Next(2) == 1)
            {
                this.Posicion[1] += rnd.Next(-3, 3);
            }
            else
            {
                this.Posicion[0] += rnd.Next(-3, 3);
            }
            
            
        }

        public abstract void Comer(object comida);
       

        public void Morir()
        {
            this.Posicion[0] = 0;
            this.Posicion[1] = 0;
            estaVivo = false;
        }
    }
}
