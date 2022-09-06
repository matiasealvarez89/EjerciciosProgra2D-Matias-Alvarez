using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Metodos_Estaticos
{
    internal class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;

            if (valor >= min && valor <= max)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
