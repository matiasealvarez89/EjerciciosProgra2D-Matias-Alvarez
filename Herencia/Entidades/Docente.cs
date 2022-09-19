using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Persona
    {
        
        private int antiguedad;
        private string titulo;

        public Docente(string nombre, string apellido, int edad, int antiguedad, string titulo) : base(nombre, apellido, edad)
        {            
            this.antiguedad = antiguedad;
            this.titulo = titulo;
        }
    }
}
