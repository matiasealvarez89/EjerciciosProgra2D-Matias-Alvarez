using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int estaBien = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (numeroIngresado <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
                else
                {
                    Console.WriteLine($"El cuadrado es {numeroIngresado * numeroIngresado} y el cubo es {numeroIngresado * numeroIngresado * numeroIngresado}");
                    estaBien = 1;
                }
            } while (estaBien == 0);
        }
    }
}
