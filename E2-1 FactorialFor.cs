using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_1_Factorial
{
    public class Factorial
    {
        public int facto(int numero)
        {
            int fact = 1;
            for (int i = 1; i <= numero; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 6;
            Stopwatch stopwatch = Stopwatch.StartNew();
            Factorial factorial = new Factorial();
            Console.Write("El factorial del numero 6 es: {0}\nEl tiempo transcurrido para realizacion la operacion: {1}", factorial.facto(numero), stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
