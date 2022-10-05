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
        static private Random rnd = new Random();

        private int saltos;
        public int Saltos { get { return saltos; } }

        private int[] dimensiones;
        public int[] Dimensiones
        {
            get { return dimensiones; }
            private set { dimensiones = value; }
        }


        public Isla(int[] dim, int hab)
        {
            saltos = 0;
            Dimensiones = new int[] { dim[0], dim[1] };

            AddQuesos(hab);
            AddHabitantes(hab);
        }


        void AddHabitantes(int n)
        {
            for (int i = 0; i < n; i++)
            {
                habitantes.Add(new Raton(this));
            }
        }

        void AddQuesos(int n) 
        {
            for (int i = 0; i < n / 2; i++)
            {
                quesos.Add(new Queso(new int[] { rnd.Next(Dimensiones[0]), rnd.Next(Dimensiones[1]) }));
            }
        }

        public ArrayList quesos = new ArrayList();
                                                  
        public ArrayList habitantes =new ArrayList();
        ArrayList embarazos = new ArrayList();

        public virtual void DarSalto() 
        {
            
            foreach(Animal hab in habitantes)
            {
                if(hab is Raton && hab.EstaVivo)
                {
                    foreach (Queso q in quesos)
                    {
                        if (hab.Posicion[0] == q.Posicion[0] && hab.Posicion[1] == q.Posicion[1])
                        {
                            hab.Comer(q);
                            break;
                        }
                    }
                    //foreach entre ratones y comparar genero/ si son distintos isla suma a un arraylist de enteros la cantidad de pasos que faltan para el nacimiento
                    for (int i = habitantes.IndexOf(hab) + 1; i < habitantes.Count; i++)
                    {
                        if (habitantes[i] is Raton)
                        {
                            Raton raton = (Raton)habitantes[i];
                            if (((Raton)habitantes[i]).Genero != ((Raton)hab).Genero)
                            {
                                if (hab.Posicion[0] == raton.Posicion[0] && hab.Posicion[1] == raton.Posicion[1])
                                {
                                    embarazos.Add(10);
                                }
                            }
                        }
                    }
                    hab.Mover();
                }
                
            }

            saltos++;
            if (saltos % 10 == 0)
            {
                foreach (Animal hab in habitantes)
                {
                    hab.SumarDia();
                }
            }

            for (int i = 0; i < embarazos.Count; i++)
            {
                int n = Convert.ToInt32(embarazos[i]);
                embarazos[i] = n - 1;
                if (Convert.ToInt32(embarazos[i]) == 0)
                {
                    int a = rnd.Next(2, 7);
                    AddHabitantes(a);
                    AddQuesos(a);

                }
            }

        }

        
    }
}
