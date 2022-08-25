using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int contador = 0;
            int iterador = 1;
            int acumulador = 0;

            while (contador < 10)
            {
                for(int i = 1; i <= iterador/2; i++)
                {
                    if (iterador % i == 0)
                    {
                        acumulador += i;
                    }
                }

                if (acumulador == iterador)
                {
                    Console.WriteLine(iterador);
                    contador++;
                }

                acumulador = 0;
                iterador++;
            }
        }
    }
}
