using System;
using Biblioteca;

namespace Ejercicio1Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int minimoIngresado = int.MaxValue;
            int maximoIngresado = int.MinValue;
            float promedio = 0;
            int contadorVueltas = 0;
            int contadorIngresosCorrectos = 0;
            int acumulador = 0;

            while(contadorVueltas < 10)
            {
                Console.WriteLine("Ingrese un numero");
                if (int.TryParse(Console.ReadLine(), out numeroIngresado) && Validador.Validar(numeroIngresado, -100, 100))
                {
                    if (contadorIngresosCorrectos == 0)
                    {
                        maximoIngresado = numeroIngresado;
                        minimoIngresado = numeroIngresado;
                    }else if(numeroIngresado > maximoIngresado)
                    {
                        maximoIngresado = numeroIngresado;
                    }
                    else if(numeroIngresado < minimoIngresado)
                    {
                        minimoIngresado = numeroIngresado;
                    }
                    acumulador += numeroIngresado;
                    contadorIngresosCorrectos++;
                }
                else
                {
                    Console.WriteLine("Ingreso incorrecto");
                }
                contadorVueltas++; 
            }
            if(contadorIngresosCorrectos != 0)
            {
                promedio = acumulador / contadorIngresosCorrectos;
            }

            Console.WriteLine($"El maximo es {maximoIngresado}, el minimo es {minimoIngresado}" +
                $"Y el promedio es {promedio}");
            
        }
    }
}
