using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, valor = 0;
            double horas = 0;

            if (int.TryParse(Console.ReadLine(), out n))
                if (int.TryParse(Console.ReadLine(), out valor))
                    if (double.TryParse(Console.ReadLine(), out horas))
                    {
                        Console.WriteLine("NUMBER = " + n);
                        Console.WriteLine("SALARY = U$ " + (valor * horas).ToString("0.00"));
                    }
            Console.ReadKey();
        }
    }
}
