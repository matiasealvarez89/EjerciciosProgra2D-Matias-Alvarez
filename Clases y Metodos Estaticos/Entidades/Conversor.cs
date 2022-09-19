using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {
        public static int ConvertirDecimalABinario(int numeroEntero) 
        {
            int retorno = 0;

            for (int i = 0; i < numeroEntero; i++)
            {
                retorno++;

                if(retorno % 2 == 0)
                {
                    retorno = (retorno -1) * 10 ;
                }
            }  

            return retorno;
        }
        /*
        public int ConvertirBinarioADecimal(int numeroEntero) 
        {
            int retorno;

            return retorno;
        }
        */
    }
}
