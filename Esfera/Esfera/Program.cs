using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double raio = 0;

            if (double.TryParse(Console.ReadLine(), out raio))
                Console.WriteLine("VOLUME = " +((4 / 3.0) * pi * (raio * raio * raio)).ToString("0.000"));
        }
    }
}
