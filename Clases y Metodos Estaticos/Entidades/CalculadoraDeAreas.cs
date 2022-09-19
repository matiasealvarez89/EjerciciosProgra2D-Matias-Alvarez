using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CalculadoraDeAreas
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double retorno = 0;

            if(longitudLado > 0)
            {
                retorno = longitudLado * longitudLado;
            }

            return retorno;
        }

        public static double CalcularAreaTriangulo(double basetriangulo, double altura)
        {
            double retorno = 0;

            if (basetriangulo > 0 && altura > 0)
            {
                retorno = basetriangulo * altura / 2;
            }

            return retorno;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double retorno = 0;

            if (radio > 0)
            {
                retorno = Math.PI * (radio * radio);
            }

            return retorno;
        }
    }
}
