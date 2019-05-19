using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosCap5_8.Capitulo_8
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Fechabutton_Click(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToString("hh:mm tt dd' de 'MMM' del 'yyyy ");

        }
    }
}
