using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese la altura del triangulo");
            if(int.TryParse(Console.ReadLine(), out altura))
            {
                for(int i = 1; i <= altura; i++)
                {
                    CantidadAsteriscos(i);
                }
            }
            else
            {
                Console.WriteLine("Ingreso incorrecto");
            }
        }

        static void CantidadAsteriscos(int vuelta)
        {
            for(int i = 0; i < vuelta; i++)
            {
                Console.Write("*");                
            }
            Console.WriteLine("");
        }
    }
}
