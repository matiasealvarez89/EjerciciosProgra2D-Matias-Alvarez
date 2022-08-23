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
            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                numeroIngresado = int.Parse(Console.ReadLine());

                if(i == 0)
                {
                    minimo = numeroIngresado;
                    maximo = numeroIngresado;                    
                }

                if(numeroIngresado < minimo)
                {
                    minimo = numeroIngresado;
                }else if(numeroIngresado > maximo)
                {
                    maximo = numeroIngresado;
                }
            }

            Console.WriteLine($"El minimo es: {minimo} y el maximo es {maximo}");

        }
    }
}
