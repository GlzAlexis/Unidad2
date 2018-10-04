using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaProcesos;

namespace PE2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            int Cantidad = 0;
            try
            {
                Console.Write("De la siguientes opciones elija el proceso que desee realizar \n1.- Encontrar el valor maximo del Arreglo \n2.- Encontrar el valor minimo del arreglo \n3.- Invertir la sucesion \n4.- Salir del programa" +
                "\nTeclee el numero de la opcion que desee: "); opc = Convert.ToInt32(Console.ReadLine()); Console.Clear();
                Procesos Traer = new Procesos();

                switch (opc)
                {
                    case 1:
                        Console.Write("Escriba la cantidad de datos que desea: "); Cantidad = Convert.ToInt32(Console.ReadLine());
                        int[] Arreglo = new int[Cantidad];
                        Arreglo = Traer.Numeros(Cantidad);
                        Console.Write("\nEl valor minimo es: {0}", Traer.NoMayor(0, Arreglo[0], Arreglo)); Console.ReadKey(); break;
                    case 2:
                        Console.Write("Escriba la cantidad de datos que desea: "); Cantidad = Convert.ToInt32(Console.ReadLine());
                        int[] Arreglo2 = new int[Cantidad];
                        Arreglo = Traer.Numeros(Cantidad);
                        Console.Write("\nEl valor minimo es: {0}", Traer.NoMenor(0, Arreglo[0], Arreglo)); Console.ReadKey(); break;
                    case 3:
                        Console.Write("Escriba la cantidad de datos que desea: "); Cantidad = Convert.ToInt32(Console.ReadLine());
                        int[] Arreglo3 = new int[Cantidad];
                        Arreglo = Traer.Numeros(Cantidad);
                        Console.Write("\nLa sucesion invertida: "); Traer.Inverso(Cantidad, Arreglo); Console.ReadKey(); break;
                    case 4:
                        Console.Write("Presione cualquier tecla para salir"); Console.ReadKey(); break;
                }
                Console.WriteLine("Gracias por utilizar el programa"); Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n"+ e.Message);
                Console.ReadKey();
            }
        }
    }
}
