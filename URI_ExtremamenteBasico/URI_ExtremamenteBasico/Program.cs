using System;

namespace URI_ExtremamenteBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3 = 0;
            try
            {
                n1 = Convert.ToInt32(Console.ReadLine());
                n2 = Convert.ToInt32(Console.ReadLine());
                n3 = (n1 + n2);
                Console.Write("X = " + n3 + '\n');
            }
            catch
            {

            }
        }
    }
}
