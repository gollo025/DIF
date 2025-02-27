using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIF.Forms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void practica2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void practica1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            GestionDeContactos practica1 = new GestionDeContactos();

            practica1.Show();

           

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Practica2 practica2 = new Practica2();

            practica2.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Practica3 practica3 =new Practica3();

            practica3.Show();
        }

        private void dllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dllFunciona fun = new dllFunciona();

            fun.Show();
        }
    }
}
