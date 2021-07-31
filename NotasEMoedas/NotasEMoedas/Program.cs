using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedulas
{
    class Program
    {
        static int Notas(double nota, ref double total)
        {
            int count = 0;
            for (int i = 0; ; i++)
            {
                if (total >= nota)
                {
                    total -= nota;
                    total = Math.Round(total, 2);
                    count++;
                }
                if (total < nota)
                    break;
            }
            return count;
        }
        static void SeparaNotas(ref int[] notas, double n)
        {
            notas[0] = Notas(100.0, ref n);
            notas[1] = Notas(50.0, ref n);
            notas[2] = Notas(20.0, ref n);
            notas[3] = Notas(10.0, ref n);
            notas[4] = Notas(5.0, ref n);
            notas[5] = Notas(2.0, ref n);
            notas[6] = Notas(1.0, ref n);
            notas[7] = Notas(0.5, ref n);
            notas[8] = Notas(0.25, ref n);
            notas[9] = Notas(0.10, ref n);
            notas[10] = Notas(0.05, ref n);
            notas[11] = Notas(0.01, ref n);

        }
        static void Main(string[] args)
        {
            double n = 0;
            int[] notas = new int[12];
            if (double.TryParse(Console.ReadLine(), out n))
            {
                SeparaNotas(ref notas, n);
                Console.WriteLine("NOTAS:");
                Console.WriteLine(notas[0] + " nota(s) de R$ 100.00");
                Console.WriteLine(notas[1] + " nota(s) de R$ 50.00");
                Console.WriteLine(notas[2] + " nota(s) de R$ 20.00");
                Console.WriteLine(notas[3] + " nota(s) de R$ 10.00");
                Console.WriteLine(notas[4] + " nota(s) de R$ 5.00");
                Console.WriteLine(notas[5] + " nota(s) de R$ 2.00");
                Console.WriteLine("MOEDAS:");
                Console.WriteLine(notas[6] + " moeda(s) de R$ 1.00");
                Console.WriteLine(notas[7] + " moeda(s) de R$ 0.50");
                Console.WriteLine(notas[8] + " moeda(s) de R$ 0.25");
                Console.WriteLine(notas[9] + " moeda(s) de R$ 0.10");
                Console.WriteLine(notas[10] + " moeda(s) de R$ 0.05");
                Console.WriteLine(notas[11] + " moeda(s) de R$ 0.01");
            }
        }
    }
}
