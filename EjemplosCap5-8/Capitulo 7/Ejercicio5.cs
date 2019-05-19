using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosCap5_8.Capitulo_7
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        /*
          //5- Hacer un programa que funcione como una agenda telefónica y que guarde el nombre de la persona y su número telefónico.
        static void Main(string[] args)
        {
            Hashtable agenda = new Hashtable();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("1- Agregar contacto");
                Console.WriteLine("2- Buscar contacto");
                Console.WriteLine("3- Eliminar contacto");
                Console.WriteLine("4- Ver todos los contactos");
                Console.WriteLine("5- Salir");
                Console.Write("Que desea realizar: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            string nombre, numero;
                            Console.Write("Ingrese el nombre del nuevo contacto: ");
                            nombre = Console.ReadLine();
                            Console.Write("Ingrese el numero del nuevo contacto: ");
                            numero = Console.ReadLine();
                            agenda.Add(nombre, numero);
                        }
                        break;

                    case 2:
                        {
                            Console.Clear();
                            string nombre, no, num;
                            bool existe;
                            Console.Write("Contacto desea buscar: ");
                            nombre = Console.ReadLine();
                            existe = agenda.Contains(nombre);
                            if (existe == false)
                            {
                                Console.Write("Este contacto no se encuentra en su agenda.");
                                Console.ReadKey();
                            }
                            else
                            {
                                foreach (DictionaryEntry contacto in agenda)
                                {
                                    if ((string)contacto.Key == nombre)
                                    {
                                        no = (string)contacto.Key;
                                        num = (string)contacto.Value;
                                        Console.Write("Nombre: {0}\nNummero: {1}", no, num);
                                        Console.ReadKey();
                                        break;
                                    }
                                }
                            }
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();
                            string nombre;
                            bool existe;
                            Console.Write("Contacto desea eliminar: ");
                            nombre = Console.ReadLine();
                            existe = agenda.Contains(nombre);
                            if (existe == false)
                            {
                                Console.Write("Este contacto no se encuentra en su agenda.");
                                Console.ReadKey();
                            }
                            else
                            {
                                agenda.Remove(nombre);
                                Console.Write("\n\nEl contacto a sido eliminado con exito");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            foreach (DictionaryEntry contacto in agenda)
                                Console.WriteLine("Nombre: {0} \t\t\t\tNumero: {1}", contacto.Key, contacto.Value);
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        break;
                }
            } while (opcion > 0 && opcion < 5);
        }*/
    }
}
