using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final;
            int retorno;
            Console.WriteLine("Ingrese un numero");
            if(int.TryParse(Console.ReadLine(), out final))
            {
                for(int i = 1; i <= final; i++)
                {
                    if(EsCentro(i) == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Ingreso incorrecto");
            }

        }

        static int EsCentro(int numero)
        {
            int retorno = 0;
            int acumuladorMenores = 0;
            int acumuladorMayores = 0;

            for(int i = 1; i < numero; i++)
            {
                acumuladorMenores += i;
            }

            for(int i = numero + 1; acumuladorMayores < acumuladorMenores; i++)
            {
                acumuladorMayores += i;
            }

            if(acumuladorMayores == acumuladorMenores && numero != 1)
            {
                retorno = 1;
            }

            return retorno;
        }
    }
}
