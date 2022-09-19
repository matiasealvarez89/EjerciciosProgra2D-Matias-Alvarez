using System;

namespace Entidades
{
    public class Validador
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

            public static bool ValidarRespuesta(string respuesta)
            {
                bool retorno = false;

                if (respuesta == "s")
                {
                    retorno = true;
                }

                return retorno;
            }        
    }
}
