using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1Lab2FaustWaigandt
{
    public partial class FormIsla : Form
    {
        public static Random rnd = new Random();
        Isla Isla;
        public FormIsla(int[] coord, int r, bool predadores, int g )
        {
            InitializeComponent();
            if (predadores)
            {
                Isla = new IslaConGatos(coord,r ,g);
            }
            else
            {
                Isla = new Isla(coord, r);
            }
            

            //setea tamaño de la isla y tamaño de celdas
            DgvIsla.Height = (coord[0] * 50) + 3;
            DgvIsla.Width = (coord[1] * 50) + 3;
            DgvIsla.RowCount = coord[0];
            DgvIsla.ColumnCount = coord[1];

            
            for (int i=0; i < coord[0]; i++) 
            {
                DgvIsla.Rows[i].Height = 50;
            }
            for (int i = 0; i < coord[1]; i++) { 
                DgvIsla.Columns[i].Width = 50;  
            }

            this.Width = DgvIsla.Width + 435;
            this.Height= DgvIsla.Height + 85;


            mostrarHabitantes();

            LlenarList();
           
        }

        private void FormIsla_Shown(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Isla.DarSalto();
            ClearIsla();
            mostrarHabitantes();
            LlenarList();


            
        }

        void ClearIsla()
        {
            for (int i = 0; i < DgvIsla.Rows.Count; i++)
            {
                for(int j=0; j < DgvIsla.Rows[i].Cells.Count; j++)
                {
                    DgvIsla.Rows[i].Cells[j].Value = "";
                }
            }
        }

        void mostrarHabitantes()
        {
            foreach (Queso q in Isla.quesos)
            {
                if(q.Porciones>0)
                DgvIsla.Rows[q.Posicion[0]].Cells[q.Posicion[1]].Value = "Q";
            }
            foreach(Animal hab in Isla.habitantes)
            {
                if (hab.EstaVivo)
                {
                    string h=hab is Raton?"R":"G";

                    DgvIsla.Rows[hab.Posicion[0]].Cells[hab.Posicion[1]].Value += h;
                }
                    
            }
        }

        void LlenarList()
        {
            listBox1.Items.Clear();
            foreach (Queso q in Isla.quesos)
            {
                if (q.Porciones > 0)
                    listBox1.Items.Add(q.ToString());
            }
            foreach (Animal hab in Isla.habitantes)
            {
                if (hab.EstaVivo)
                    listBox1.Items.Add(hab.ToString());
            }
        }

        private void FormIsla_Load(object sender, EventArgs e)
        {

        }
    }
}
