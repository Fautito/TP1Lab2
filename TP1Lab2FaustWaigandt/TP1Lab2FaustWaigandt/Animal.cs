using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Lab2FaustWaigandt
{
    abstract class Animal
    {
        public Animal(Isla isla)
        {
            this.i = isla;
            
            //necesita recibir la posicion en un int[] ,indice 0 para las filas, indice 1 para las columnas
            //debe conocer a Isla para acceder a las dimensiones y saber si se cae al agua (raton) o se acerca a los bordes (gato)
            //inicializa en cero pasos sin comer
            //inicializa esta vivo en true
        }
        protected Isla i;
        private int[] posicion;
        public int[] Posicion { get { return posicion; } private set { posicion = value; } }


        private bool estaVivo;
        public bool EstaVivo { get { return estaVivo; } }

        

        protected int pasosSinComer;



        public virtual void Mover()
        {
            //falta hacer que el animal se mueva
            //  un random para indicar la direccion(1 o 0)
            //  otro random entre -3 y 3 para indicar las posiciones (los numeros negativos indican pasos hacia atras, entonces con indicar un eje X o Y y una cantidad de pasos negativa o positiva ya se puede mover
            //en todas las direcciones
            //  este metodo se socreescribe en la clase gato, que tiene que ver que no se acerque al borde de la isla
        }

        public abstract void Comer(object comida);
        //en la clase raton pregunta si es queso, lo come(resta una porcion) reinicia el contadro de dias sin comer 
        //en la clase gato pregunta si es un raton, lo mata y reinicia el contador de dias sin comer

        public void Morir()
        {
            estaVivo = false;
        }
    }
}
