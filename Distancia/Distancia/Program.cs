using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia = 0;

            if (double.TryParse(Console.ReadLine(), out distancia))
                Console.WriteLine((distancia * 2) + " minutos");
        }
    }
}
