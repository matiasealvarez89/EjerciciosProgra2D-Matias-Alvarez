using System;

namespace ClassLibrary1
{
    public class Validador
    {
        private static bool Validar(int valor, int min, int max)
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
