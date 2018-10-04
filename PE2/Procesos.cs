using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProcesos
{
    public class Procesos
    {
        public int[] Numeros(int Cantidad)
        {
            int[] Arreglo = new int[Cantidad];
            for (int i = 0; i < Cantidad; i++) { Console.Write("Ingresa un valor {0}: ", (i + 1)); Arreglo[i] = Convert.ToInt32(Console.ReadLine()); }
            return Arreglo;
        }

        public int NoMayor(int i, int Mayor, int[] Arreglo)
        {
            if (i != Arreglo.Length)
            {
                if (Arreglo[i] > Mayor) { Mayor = NoMayor((i + 1), Arreglo[i], Arreglo); }
                else { Mayor = NoMayor((i + 1), Mayor, Arreglo); }
            }
            return Mayor;
        }
        public int NoMenor(int i, int Menor, int[] Arreglo)
        {
            if (i != Arreglo.Length)
            {
                if (Arreglo[i] < Menor) { Menor = NoMenor((i + 1), Arreglo[i], Arreglo); }
                else { Menor = NoMenor((i + 1), Menor, Arreglo); }
            }
            return Menor;
        }
        public void Inverso(int i, params int[] Arreglo)
        {
            double Posicion = 0;
            if (i > 0)
            {
                Posicion = Arreglo[i - 1];
                Console.Write(Posicion + " ");
                Inverso(i - 1, Arreglo);
            }
        }
    }
}
