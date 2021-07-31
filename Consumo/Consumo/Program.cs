using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;

            if (double.TryParse(Console.ReadLine(), out a))
                if (double.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine((a / b).ToString("0.000") + " km/l");
        }
    }
}
