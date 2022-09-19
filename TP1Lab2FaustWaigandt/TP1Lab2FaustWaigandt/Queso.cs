using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Lab2FaustWaigandt
{
    class Queso
    {
        
        public Queso(int[] pos)
        {
            porciones = 2;
            Posicion = pos;
        }



        private int porciones;
        public int Porciones { get { return porciones; } }


        private int[] posicion;
        public int[] Posicion { get { return posicion; } private set { posicion = value; } }

        public void SerComido()
        { if (porciones > 0) porciones--; }
    }
}
