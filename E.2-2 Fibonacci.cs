using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E._2_2_Fibonacci
{
    public class Fibonacci
    {
        public int Recursivo(int numero)
        {
            if (numero == 1 || numero == 0) { return numero; }
            else { return Recursivo(numero - 1) + Recursivo(numero - 2); }
        }

        public void Iterativo ()
        {
            int numero = 0,Inicio = 0, Medio = 1, Result = 0;
            Console.Write("\nIngrese la cantidad de numeros: "); numero = Convert.ToInt32(Console.ReadLine());
            Stopwatch Time = Stopwatch.StartNew();
            for (int i = 0; i < numero; i++)
            {
                Result = Inicio; Inicio = Medio; Medio = Result + Inicio;
                Console.Write(Inicio + ", ");
            }
            Console.Write("El tiempo de ejecucion es de: {0}", Time.Elapsed);
        }
        ~Fibonacci() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numero;           
            Console.Write("Ingrese la cantidad de numeros: "); numero = Convert.ToInt32(Console.ReadLine());
            Fibonacci Sucesion = new Fibonacci();
            Stopwatch Time = Stopwatch.StartNew();
            Console.Write(" "+Sucesion.Recursivo(numero)+"    ");
            Console.Write("El tiempo de ejecucion es de: {0}", Time.Elapsed);
            Sucesion.Iterativo();
            Console.ReadKey();
        }
    }
}
