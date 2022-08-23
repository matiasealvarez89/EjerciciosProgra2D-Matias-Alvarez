using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            float promedio = 0;
            int divisor = 5;
            int flag = 0;
            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    if (flag == 0)
                    {
                        minimo = numeroIngresado;
                        maximo = numeroIngresado;
                    }
                    else if (numeroIngresado < minimo)
                    {
                        minimo = numeroIngresado;
                    }
                    else if (numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }

                    promedio = promedio + numeroIngresado;
                }else
                {
                    divisor--;
                }
            }

            if(divisor != 0)
            {
                promedio = promedio / divisor;
            }

            Console.WriteLine($"El minimo es: {minimo}, el maximo es {maximo} y el promedio es {promedio}");

        }
    }
}
