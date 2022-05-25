using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Buenas tardes, hola" + " " + nombre + " " + "Le gustaria ver el menu? ");
            Console.ReadKey();
        }
    }
}