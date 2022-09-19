using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gerente
    {
        string nombreCompleto;
        int antiguedad;
        int edad;
        float ganancia;

        public Gerente(string nombreCompleto, int antiguedad, int edad, float ganancia)
        {
            this.nombreCompleto = nombreCompleto;
            this.antiguedad = antiguedad;
            this.edad = edad;
            this.ganancia = ganancia;
        }

        
    }
}
