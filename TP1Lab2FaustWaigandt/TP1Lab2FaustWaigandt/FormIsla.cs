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
        public FormIsla(int[] coord, int q, int r)
        {
            InitializeComponent();

            Isla = new Isla(coord,q,r);

            //setea tamaño de la isla y tamaño de celdas
            DgvIsla.Height = (coord[0] * 50) + 3;
            DgvIsla.Width = (coord[1] * 50) + 3;
            DgvIsla.RowCount = coord[0];
            DgvIsla.ColumnCount = coord[1];

            


            //Isla.h
            for (int i=0; i < coord[0]; i++) 
            {
                DgvIsla.Rows[i].Height = 50;
            }
            for (int i = 0; i < coord[1]; i++) { 
                DgvIsla.Columns[i].Width = 50;
                
            }

             
            this.Width = DgvIsla.Width + 35;
            this.Height= DgvIsla.Height + 85;


            

            //for (int i = q; i >0; i--)
            //{
            //    DgvIsla.Rows[rnd.Next(coord[0])].Cells[rnd.Next(coord[1])].Value = "Q";
            //}
            //for (int i = r; i > 0; i--)
            //{
            //    DgvIsla.Rows[rnd.Next(coord[0])].Cells[rnd.Next(coord[1])].Value += "R";
            //}
           
        }

        private void FormIsla_Shown(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
