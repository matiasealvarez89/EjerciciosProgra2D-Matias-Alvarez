using System;

namespace Clases_y_Metodos_Estaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numeroIngresado;
            int minimoIngresado = int.MaxValue;
            int maximoIngresado = int.MinValue;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100");
                if (int.TryParse(Console.ReadLine(), out numeroIngresado) && Validador.Validar(numeroIngresado, -100, 100))
                {
                    if(contador == 0)
                    {
                        minimoIngresado = numeroIngresado;
                        maximoIngresado = numeroIngresado;                        
                    }
                    else if(numeroIngresado < minimoIngresado)
                    {
                        minimoIngresado = numeroIngresado;
                    }
                    else if(numeroIngresado > maximoIngresado)
                    {
                        maximoIngresado = numeroIngresado;
                    }

                    acumulador += numeroIngresado;                   
                    
                }
                else
                {
                    Console.WriteLine("Ingreso incorrecto");
                }
                
                contador++;

            } while (contador != 10);

            Console.WriteLine($"El maximo es {maximoIngresado}, el minimo es {minimoIngresado} y el promedio es {acumulador/10}");
        }
    }
}
