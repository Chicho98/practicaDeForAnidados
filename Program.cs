using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for anidados
            Console.WriteLine("cuantas rows o filas?");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cuantas columnas?");
            int columnas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("que simbolo queres papu?");
            string simbolo = Console.ReadLine(); 
            
             for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columnas; j++) 
                {
                    Console.Write(simbolo);
                }
                Console.WriteLine();
            }
             Console.ReadKey();
        }
    }
}
