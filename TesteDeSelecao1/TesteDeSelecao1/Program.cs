using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeSelecao1
{
    class Program
    {
        static bool Test (int a, int b, int c, int d)
        {
            if (b > c && d > a)
                if ((c + d) > (a + b))
                    if (c > 0 && d > 0)
                        if ((a % 2) == 0)
                            return true;
            return false;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);
            int c = Convert.ToInt32(input[2]);
            int d = Convert.ToInt32(input[3]);
            if (Test(a, b, c, d))
                Console.WriteLine("Valores aceitos");
            else
                Console.WriteLine("Valores nao aceitos");

        }
    }
}
