using Entidades;
using System;
using System.Collections.Generic;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnado = new List<Alumno>();
            List<Docente> listadoDocentes = new List<Docente>();
            
            Docente docente1 = new Docente("Orne", "C.", 20, 2, "Todos");

            Alumno alumno1 = new Alumno("Matias", "A", 20, 2, 5);
            Alumno alumno2 = new Alumno("Jorge", "A", 20, 2, 5);

            alumnado.Add(alumno2);
            alumnado.Add(alumno1);

            Console.WriteLine(alumno1.Comer());

            listadoDocentes.Add(docente1);


        }
    }
}
