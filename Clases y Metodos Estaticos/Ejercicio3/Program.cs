using System;
using Entidades;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroConvertido = 0;

            Console.WriteLine("Ingrese un numero");
            if(int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                numeroConvertido = Conversor.ConvertirDecimalABinario(numeroIngresado);
            }

            Console.WriteLine(numeroConvertido);
        }
    }
}
