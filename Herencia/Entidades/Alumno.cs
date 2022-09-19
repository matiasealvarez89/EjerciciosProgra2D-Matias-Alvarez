using System;

namespace Entidades
{
    public class Alumno : Persona
    {
        
        private int nota1;
        private int nota2;

        

        public Alumno(string nombre, string apellido, int edad, int nota1, int nota2):base(nombre, apellido, edad)
        {            
            this.nota1 = nota1;
            this.nota2 = nota2;
        }
    }
}
