using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static float Calcular(float primerOperando, float segundoOperando, string operacion)
        {
            float retorno = 0;

            if(operacion == "*" || operacion == "+" || operacion == "-" || operacion == "/")
            {
                switch (operacion)
                {
                    case "+":
                        retorno = primerOperando + segundoOperando;
                        break;
                    case "-":
                        retorno = primerOperando - segundoOperando;
                        break;
                    case "*":
                        retorno = primerOperando * segundoOperando;
                        break;
                    case "/":
                        if(Validar(segundoOperando))
                        {
                            retorno = primerOperando / segundoOperando;
                        }
                        break;
                }
            }
            return retorno;
        }

        private static bool Validar(float numeroValidar)
        {
            bool retorno = false;

            if(numeroValidar != 0)
                retorno = true;
            return retorno;
        }

        public static string Tablas(int numero)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tabla de multiplicar del numero {numero}");
            sb.AppendLine($"{numero} x 1 = {numero}");
            sb.AppendLine($"{numero} x 2 = {numero * 2}");
            sb.AppendLine($"{numero} x 3 = {numero * 3}");
            sb.AppendLine($"{numero} x 4 = {numero * 4}");
            sb.AppendLine($"{numero} x 5 = {numero * 5}");
            sb.AppendLine($"{numero} x 6 = {numero * 6}");
            sb.AppendLine($"{numero} x 7 = {numero * 7}");
            sb.AppendLine($"{numero} x 8 = {numero * 8}");
            sb.AppendLine($"{numero} x 9 = {numero * 9}");

            return sb.ToString();
        }
    }
}
