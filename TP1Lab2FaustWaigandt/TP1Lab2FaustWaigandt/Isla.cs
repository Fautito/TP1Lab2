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


        public ArrayList quesos = new ArrayList();//array quesos. al ser comido, resta una porcion,
                                                  //tenemos q filtrar los quesos que tienen 0 porciones,
                                                  //quitarlos o que no se tengan en cuenta para volve a dibujar los elementos en sus posiciones
        ArrayList habitantes =new ArrayList();  


        public void DarSalto() 
        {
            saltos++; //suma una salto y recorre los array de quesos y habitantes
                      //cada habitante hace sus movimientos
                      //y vuelve a dibujar los que no estan muertos o comidos con las posiciones ya actualizadas
        }
    }
}
