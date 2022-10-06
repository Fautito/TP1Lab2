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

        //agrega 1 queso cada 2 habitantes ratones (antes de que el constructor de IslaConGatos agregue los gatos a la lista de habitantes) 
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

            ArrayList raton = new ArrayList();
            foreach (Animal hab in habitantes)
            {

                if (hab is Raton && hab.EstaVivo)
                {
                    raton.Add(hab);
                }
            }

            //for entre ratones y comparar genero/ si son distintos isla suma a un arraylist de enteros la cantidad de pasos que faltan para el nacimiento
            //los machos embarazan a todas las hembras q comparten posicion
            //las hembras  tienen tantos embarazos como machos en su posicion

            foreach (Raton r in raton)
            {
                for (int i = raton.IndexOf(r) + 1; i < raton.Count; i++)
                {
                    Raton r2 = (Raton)raton[1];
                    if (r2.Genero != r.Genero)
                    {
                        if (r.Posicion[0] == r2.Posicion[0] && r.Posicion[1] == r2.Posicion[1])
                        {
                            embarazos.Add(10);
                        }
                    }
                }

                //por cada raton se recorre los quesos buscando uno que tenga la misma posicion para comerlo
                foreach (Queso q in quesos)
                {
                    if (r.Posicion[0] == q.Posicion[0] && r.Posicion[1] == q.Posicion[1])
                    {
                        r.Comer(q);//una vez q come, rompe la iteracion
                        break;
                    }
                }

                r.Mover(); //Mueve luego de aparearse y comer para que al volver a dibujarse
                           //se pueda anticipar lo que va a suceder en el proximo paso
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
