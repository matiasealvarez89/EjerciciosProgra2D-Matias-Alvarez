using Entidades;
using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float primerNumero;
            float segundoNumero;
            string operador;
            float resultado;

            do
            {
                Console.WriteLine("Ingrese el primer operando");
                float.TryParse(Console.ReadLine(), out primerNumero);
                Console.WriteLine("Ingrese el segundo operando");
                float.TryParse(Console.ReadLine(), out segundoNumero);
                Console.WriteLine("Ingrese el operador");
                operador = Console.ReadLine();

                resultado = Calculadora.Calcular(primerNumero, segundoNumero, operador);
                Console.WriteLine($"El resultado es {resultado}");

                //Faltan muchas validaciones

            } while (true);

        }
    }
}
