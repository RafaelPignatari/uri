using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferença
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0;

            if (int.TryParse(Console.ReadLine(), out a))
                if (int.TryParse(Console.ReadLine(), out b))
                    if (int.TryParse(Console.ReadLine(), out c))
                        if (int.TryParse(Console.ReadLine(), out d))
                            Console.WriteLine("DIFERENCA = " + ((a * b) - (c * d)).ToString());
        }
    }
}
