using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace TABLA_DE_MULTIPLICAR_CON_WHILE
{
    class Program
    {
        static void Main(String[] args)
        {
            int NUM, I, RESUL;
            string linea;
            Console.Write("DIGITE NÚMERO: "); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            I = 1;
            while ((I <= 12))
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} = {2} ", NUM, I, RESUL);
                I = I + 1;
            }
            Console.Write("Pulse una tecla: "); Console.ReadLine();
        }
    }
}