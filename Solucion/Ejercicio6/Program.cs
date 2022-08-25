using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimo;
            int maximo;

            Console.WriteLine("Ingrese el año de inicio");
            _ = int.TryParse(Console.ReadLine(), out minimo);
            Console.WriteLine("Ingrese el año de final");
            _ = int.TryParse(Console.ReadLine(), out maximo);

            if(minimo <= maximo)
            {
                for(int i = minimo; i <= maximo; i++)
                {
                    if((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Lo escribiste mal");
            }

        }
    }
}
