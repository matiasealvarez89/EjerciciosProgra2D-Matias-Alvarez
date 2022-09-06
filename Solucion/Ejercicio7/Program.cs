using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicadorAnos = 150;
            double porcentajeNeto = 0.87;
            int respuesta = 0;
            int contador = 0;
            Empleado[] lista = new Empleado[20];

            do
            {
                //Console.WriteLine("Ingrese el nombre del empleado:");
                //lista[contador].nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                int.Parse(Console.ReadLine(out lista[contador].horas));
                Console.WriteLine("Ingrese el valor hora:");
                lista[contador].valorHora = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la antigüedad:");
                lista[contador].antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Desea cargar otro empleado? 1) Si 2) No");
                respuesta = int.Parse(Console.ReadLine());
                if(respuesta == 1)
                {
                    contador++;
                }

            } while (respuesta != 2);

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i].nombre);
                Console.WriteLine(lista[i].horas);
            }
        }


    }
}
