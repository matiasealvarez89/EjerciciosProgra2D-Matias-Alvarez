using System;
using Entidades;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("Ingrese la opcion deseada:\n1)Cuadrado\n2)Triangulo\n3)Circulo");
                if(int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {                        
                        case 1:
                            Console.WriteLine("Ingrese la longitud del lado del cuadrado");
                            if(int.TryParse(Console.ReadLine(), out int lado))
                            {
                                double resutldado = CalculadoraDeAreas.CalcularAreaCuadrado(lado);
                                Console.WriteLine($"El resultado es {resutldado}");
                            }
                            else
                            {
                                Console.WriteLine("Ingreso incorrecto");
                            }
                            break;
                        case 2:
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el radio del circulo");
                            if (int.TryParse(Console.ReadLine(), out int radio))
                            {
                                double resutldado = CalculadoraDeAreas.CalcularAreaCirculo(radio);
                                Console.WriteLine($"El resultado es {resutldado}");
                            }
                            else
                            {
                                Console.WriteLine("Ingreso incorrecto");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingreso incorrecto");                    
                }

            } while (true);
            
        }
    }
}
