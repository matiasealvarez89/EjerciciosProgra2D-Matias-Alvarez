using System;

namespace Excecpiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                int num = int.Parse("");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("");
        }
    }
}
