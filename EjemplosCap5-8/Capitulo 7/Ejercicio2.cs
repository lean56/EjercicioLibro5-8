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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        /*
         
                 //2- Hacer un programa que funcione como un diccionario, con palabra y definición, usando el Hashtable.
        static void Main(string[] args)
        {
            Hashtable diccionario = new Hashtable();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("1- Agregar palabra");
                Console.WriteLine("2- Buscar palabra");
                Console.WriteLine("3- Ver todas las palabras");
                Console.WriteLine("4- Salir");
                Console.Write("Que desea realizar: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            string palabra, significado;
                            Console.Write("Ingrese es la palabra a agregar: ");
                            palabra = Console.ReadLine();
                            Console.Write("Ingrese el significado de la palabra: ");
                            significado = Console.ReadLine();
                            diccionario.Add(palabra, significado);
                        }
                        break;

                    case 2:
                        {
                            Console.Clear();
                            string nombre, no, sig;
                            bool existe;
                            Console.Write("Que palabra desea buscar: ");
                            nombre = Console.ReadLine();
                            existe = diccionario.Contains(nombre);
                            if(existe == false)
                            {
                                Console.Write("Esta palabra no se encuentra en el diccionario.");
                                Console.ReadKey();
                            }
                            else
                            {
                                foreach (DictionaryEntry palabra in diccionario)
                                {
                                    if((string)palabra.Key == nombre)
                                    {
                                        no = (string)palabra.Key;
                                        sig = (string)palabra.Value;
                                        Console.Write("Palabra: {0}\nSignificado: {1}", no, sig);
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
                            foreach (DictionaryEntry palabra in diccionario)
                                Console.WriteLine("Palabra:\t{0} \t\tSignificado: {1}", palabra.Key, palabra.Value);
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        break;
                }
            } while (opcion > 0 && opcion < 4);
        }
         
         */
    }
}
