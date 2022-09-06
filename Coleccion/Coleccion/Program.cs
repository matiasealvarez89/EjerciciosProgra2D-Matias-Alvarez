using System;
using System.Collections;
using System.Collections.Generic;

namespace Coleccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string continua = "s";
            
            Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();

            maquinaExpendedora.Add(1, "Coca");
            maquinaExpendedora.Add(2, "Alfajor");
            maquinaExpendedora.Add(3, "Papas");
            maquinaExpendedora.Add(4, "Figus");
            maquinaExpendedora.Add(5, "Chocolate");
            maquinaExpendedora.Add(6, "Kinder");
            maquinaExpendedora.Add(7, "Levite");
            maquinaExpendedora.Add(8, "Marlboro");
            maquinaExpendedora.Add(9, "Caramelos");
            maquinaExpendedora.Add(10, "Palitos");

            do
            {

                foreach (KeyValuePair<int, string> item in maquinaExpendedora)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }

                Console.WriteLine("Seleccione el poducto");

                if (int.TryParse(Console.ReadLine(), out opcion) && maquinaExpendedora.ContainsKey(opcion))
                {
                    Console.WriteLine($"Usted compro {maquinaExpendedora[opcion]}");
                    maquinaExpendedora.Remove(opcion);
                }
                else
                {
                    Console.WriteLine("Ingresaste cualquier cosa");
                }

                Console.WriteLine("Desea comprar otro product (s - n)");
                continua = Console.ReadLine();

            } while (continua == "s");
        }
    }
}
