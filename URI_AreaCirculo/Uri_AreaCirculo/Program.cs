using System;

namespace Uri_AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = 0, pi = 3.14159;

            if (double.TryParse(Console.ReadLine(), out raio))
                Console.WriteLine("A=" + (raio * raio * pi).ToString("0.0000"));
        }
    }
}
