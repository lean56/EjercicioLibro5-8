using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemplosCap5_8.Capitulo_5;
using EjemplosCap5_8.Capitulo_8;

namespace EjemplosCap5_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ejercicio4 e4 = new Ejercicio4();
            e4.ShowDialog();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3 e3 = new Ejercicio3();
            e3.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio5 e5 = new Ejercicio5();
            e5.Show();
        }
    }
}
