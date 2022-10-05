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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NudGatos.Enabled = false;
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            int[] coord = new int[2];
            coord[0] = Convert.ToInt32(NudX.Value);
            coord[1] = Convert.ToInt32(NudY.Value);
            
            int ratones =Convert.ToInt32(NudRatones.Value); 
            int gatos =Convert.ToInt32(NudGatos.Value);
            FormIsla i = new FormIsla(coord,ratones, checkBox1.Checked,gatos);
            i.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            NudGatos.Enabled = checkBox1.Checked;
        }
    }
}
