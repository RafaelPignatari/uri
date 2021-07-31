using System;

namespace URI_SomaSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("SOMA = " + (a + b) + '\n');
            }
            catch
            {

            }
        }
    }
}
