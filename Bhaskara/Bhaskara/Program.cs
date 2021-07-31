using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double a = 0, b = 0, c = 0, delta = 0, raiz1 = 0, raiz2 = 0;

            a = Convert.ToDouble(input[0]);
            b = Convert.ToDouble(input[1]);
            c = Convert.ToDouble(input[2]);

            delta = (b * b) - (4 * a * c);
            raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
            raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
            if (raiz1.ToString() != "NaN" && raiz2.ToString() != "NaN")
            {
                Console.WriteLine("R1 = " + raiz1.ToString("0.00000"));
                Console.WriteLine("R2 = " + raiz2.ToString("0.00000"));
            }
            else
                Console.WriteLine("Impossivel calcular");
        }
    }
}
