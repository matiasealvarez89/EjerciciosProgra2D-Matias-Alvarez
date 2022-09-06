using System;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese la altura del triangulo");
            if (int.TryParse(Console.ReadLine(), out altura))
            {
                for (int i = 1; i <= altura; i++)
                {
                    CantidadAsteriscosConEspacios(i, altura);
                }
            }
            else
            {
                Console.WriteLine("Ingreso incorrecto");
            }
        }

        static void CantidadAsteriscosConEspacios(int vuelta, int altura)
        {
            for (int i = 0; i < vuelta; i++)
            {
                CantidadEspacios(altura - i);
                Console.Write("*");                
            }
            Console.WriteLine("");
        }

        static void CantidadEspacios(int vuelta)
        {
            for (int i = vuelta / 2; i > 0 ; i--)
            {
                Console.Write(" ");
            }
        }
    }
}
