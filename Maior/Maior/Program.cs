using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double maior = Convert.ToDouble(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (Convert.ToDouble(input[i]) > maior)
                    maior = Convert.ToDouble(input[i]);
            }
            Console.WriteLine(maior + " eh o maior");
        }
    }
}
