using Entidades;
using System;
using System.IO;

/*
 * Realizar un programa que sume números enteros hasta que el usuario lo determine por medio 
 * de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de 
respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó 
cualquier otro valor.
*/

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumulador = 0;
            string respuesta;

            do
            {
                Console.WriteLine("Ingrese un numero entero");
                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    acumulador += numeroIngresado;
                }
                else
                {
                    Console.WriteLine("Ingreso incorrecto");
                }

                Console.WriteLine("Desea ingresar otro numero (s/n)");

                respuesta = Console.ReadLine();
                

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine($"Suma total {acumulador}");
        }
    }
}
