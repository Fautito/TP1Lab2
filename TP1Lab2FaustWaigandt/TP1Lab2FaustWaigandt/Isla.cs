using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Lab2FaustWaigandt
{
    class Isla
    {
        
        public Isla(int[] dim, int q, int hab)
        {
            saltos = 0;
            Dimensiones = new int[] { dim[0], dim[1] };//necesita recibir la dimension en un int[] ,indice 0 para las filas, indice 1 para las columnas
            for (int i = 0; i < q; i++)
            {
                quesos.Add(new Queso(new int[] { rnd.Next(dim[0]), rnd.Next(dim[1]) }));
            }
            //crear calse animal, y ratones
            for(int i = 0; i < hab; i++)
            {
                //habitantes
            }
        }

        static private Random rnd = new Random();
        private int[] dimensiones;
        public int[] Dimensiones
        {
            get { return dimensiones; }
            private set { dimensiones = value; }
        }


        private int saltos;
        public int Saltos{ get { return saltos; } }


        ArrayList quesos = new ArrayList();
        ArrayList habitantes =new ArrayList();  


        public void DarSalto() 
        {
            saltos++; 
        }
    }
}
