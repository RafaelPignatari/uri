using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanche
{
    class Program
    {
        static double Pagar (int codigo, double qtd)
        {
            double total = 0;
            if (codigo == 1)
                total = (qtd * 4.00);
            if (codigo == 2)
                total = (qtd * 4.50);
            if (codigo == 3)
                total = (qtd * 5.00);
            if (codigo == 4)
                total = (qtd * 2.00);
            if (codigo == 5)
                total = (qtd * 1.50);
            return total;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int codigo = 0;
            double qtd = 0;

            codigo = Convert.ToInt32(input[0]);
            qtd = Convert.ToDouble(input[1]);
            Console.WriteLine("Total: R$ " + Pagar(codigo, qtd).ToString("0.00"));
        }
    }
}
