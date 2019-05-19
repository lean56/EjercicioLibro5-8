using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosCap5_8.Capitulo_5
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int numero, fact = 1;
            numero = Convert.ToInt32(NEnterotextBox.Text); 
            if (numero == 0)
            {
                NEnterotextBox.Text = fact.ToString();
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    fact = fact * i;
                    FactorialtextBox.Text = fact.ToString();
                }
            }
        }
    }
}
