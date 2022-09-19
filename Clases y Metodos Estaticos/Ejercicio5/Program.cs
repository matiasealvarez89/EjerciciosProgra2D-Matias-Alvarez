using Entidades;
using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;

            do
            {
                Console.WriteLine("Ingrese el numero para ver su tabla de multiplicacion");
                
                if(int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.WriteLine(Calculadora.Tablas(numeroIngresado));
                }
                else
                {
                    Console.WriteLine("No ingreso un numero entero");
                }
            } while (true);
        }
    }
}
