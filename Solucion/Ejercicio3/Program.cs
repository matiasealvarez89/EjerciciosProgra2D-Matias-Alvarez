using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int opcion = 1;

            do
            {
                Console.WriteLine("Ingrese un numero");
                if (int.TryParse(Console.ReadLine(), out numeroIngresado) && numeroIngresado > 1)
                {
                    Console.WriteLine("1");
                    for (int i = 0; i <= numeroIngresado; i++)
                    {
                        if (Check_NumeroPrimo(i) == 0)
                        {
                            Console.WriteLine(i);                            
                        }
                    }
                }
                else if (numeroIngresado == 1)
                {
                    Console.WriteLine(numeroIngresado);
                }else
                {
                    Console.WriteLine("Ingreso incorrecto");
                }
                
                Console.WriteLine("Desea ingresar otro numero?\n1) Ingresar otro numero\n2) Salir");
                if (int.TryParse(Console.ReadLine(), out opcion) && opcion == 2)
                {
                    Console.WriteLine("Saliendo");
                }
               
            }while (opcion != 2);
           
        }
                
        static int Check_NumeroPrimo(int numero)//
        {
            int retorno = -1;
            int i;
            
            for (i = 2; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    break;
                }
            }

            if(i == numero)
            {
                retorno = 0;
            }

            return retorno;
        }
    }
}
