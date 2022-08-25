using System;

namespace IsPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngreasado;
            
            Console.WriteLine("Ingrese un numero");
            if(int.TryParse(Console.ReadLine(), out numeroIngreasado))
            {
                if(IsPalindrome(numeroIngreasado))
                {
                    Console.WriteLine("Es palindromo");
                }else
                {
                    Console.WriteLine("No es palindromo");
                }
            }
            else
            {
                Console.WriteLine("Ingreso incorrecto");
            }
        }

        static bool IsPalindrome(int x)
        {
            int maximo = int.MaxValue;
            bool respuesta = false;
            double numeroAlRevez;
            string numeroString = " ";
            string numeroStringAlRevez = " ";


            if (x >= 0 && x < maximo)
            {
                numeroString = x.ToString();

                for (int i = numeroString.Length - 1; i >= 0; i--)
                {
                    numeroStringAlRevez += numeroString[i];
                }

                numeroAlRevez = double.Parse(numeroStringAlRevez);

                if (x == numeroAlRevez)
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }
    }
}
