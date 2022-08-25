using System;

namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "dog", "racecar", "car" };
            string aux = LongestCommonPrefix(strs);

            
            Console.WriteLine(aux);
           
        }

        static string LongestCommonPrefix(string[] strs)
        {
            string retorno = "";
            string aux = "";
            int largoPalabraMasCorta = 0;

            if (strs.Length > 1)
            {
                for (int i = 0; i < strs.Length; i++)
                {
                    if (i == 0 || largoPalabraMasCorta > strs[i].Length)
                    {
                        largoPalabraMasCorta = strs[i].Length;
                    }
                }
                               

                for (int j = 0; j < strs.Length; j++)
                {
                    for (int i = 0; i < largoPalabraMasCorta - 1; i++)
                    {
                        if (j == 0 || strs[j][i] == retorno[i])
                        {
                            aux += strs[j][i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    retorno = aux;
                    aux = "";
                }
            }
            else
            {
                retorno = strs[0];
            }


            return retorno;
        }
    }
}
