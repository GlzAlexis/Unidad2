using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_1_Factorial_recursividad
{
    public class Factorial
    {
        public int factorialrecursivo(int n)
        {
            if (n == 1) { return 1; }
            else { return n * factorialrecursivo(n - 1); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int numero = 6; Factorial factorial = new Factorial();
            Console.Write("El factorial del numero 6 es: {0}\nEl tiempo de duracion del proceso es de: {1}", factorial.factorialrecursivo(numero), stopwatch.Elapsed);
            Console.ReadKey();
        }
    }
}
