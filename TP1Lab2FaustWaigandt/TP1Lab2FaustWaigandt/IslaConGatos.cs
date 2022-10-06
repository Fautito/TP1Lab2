using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Lab2FaustWaigandt
{
    internal class IslaConGatos : Isla
    {
        //ejecuta el constrcutor de Isla y luego agrega gatos a la lista de habitantes
        public IslaConGatos(int[] dim, int hab, int g) : base(dim, hab)
        {
            for(int i = 0; i < g; i++)
            {
                habitantes.Add(new Gato(this));
            }
        }

        //primero los gatos comen a los ratones que se encuentran en la misma posiciones,
        //luego pasa al metodo de la clase base
        public override void DarSalto()
        {
            
            foreach(Animal g in habitantes)
            {
                if(g is Gato && g.EstaVivo)
                {
                    foreach (Animal r in habitantes)
                    {
                        if(r is Raton && r.EstaVivo)
                        {
                            if (g.Posicion[0] == r.Posicion[0] && g.Posicion[1] == r.Posicion[1])
                            {
                                g.Comer(r);

                            }
                        }
                    }
                    g.Mover();
                }
            }
            base.DarSalto();
        }
    }
}
