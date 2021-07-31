using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalo
{
    class Program
    {
        static int Intervalo(double n)
        {
            if (n >= 0.0000 && n <= 25.0000)
                return 1;
            if (n > 25.0000 && n <= 50.0000)
                return 2;
            if (n > 50.0000 && n <= 75.0000)
                return 3;
            if (n > 75.0000 && n <= 100.0000)
                return 4;
            return -1;
        }
        static void Main(string[] args)
        {
            double n = 0;
            if (double.TryParse(Console.ReadLine(),out n))
            {
                switch (Intervalo(n))
                {
                    case 1:
                        Console.WriteLine("Intervalo [0,25]");
                        break;
                    case 2:
                        Console.WriteLine("Intervalo (25,50]");
                        break;
                    case 3:
                        Console.WriteLine("Intervalo (50,75]");
                        break;
                    case 4:
                        Console.WriteLine("Intervalo (75,100]");
                        break;
                    default:
                        Console.WriteLine("Fora de intervalo");
                        break;

                }
            }
        }
    }
}
