using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedulas
{
    class Program
    {
        static int Notas (int nota,ref double total)
        {
            int count = 0;
            for (int i = 0; ; i++)
            {
                if (total >= nota)
                {
                    total -= nota;
                    count++;
                }
                if (total < 100)
                    break;
            }
            return count;
        }
        static void SeparaNotas (ref int[] notas, double n)
        {
            notas[0] = Notas(100,ref n);
            notas[1] = Notas(50,ref n);
            notas[2] = Notas(20,ref n);
            notas[3] = Notas(10,ref n);
            notas[4] = Notas(5,ref n);
            notas[5] = Notas(2,ref n);
            notas[6] = Notas(1,ref n);
        }
        static void Main(string[] args)
        {
            double n = 0;
            int[] notas = new int[7];
            if (double.TryParse(Console.ReadLine(), out n))
            {
                SeparaNotas(ref notas, n);
                Console.WriteLine(n);
                Console.WriteLine(notas[0] + " nota(s) de R$ 100,00");
                Console.WriteLine(notas[1] + " nota(s) de R$ 50,00");
                Console.WriteLine(notas[2] + " nota(s) de R$ 20,00");
                Console.WriteLine(notas[3] + " nota(s) de R$ 10,00");
                Console.WriteLine(notas[4] + " nota(s) de R$ 5,00");
                Console.WriteLine(notas[5] + " nota(s) de R$ 2,00");
                Console.WriteLine(notas[6] + " nota(s) de R$ 1,00");
            }
            Console.ReadKey();
        }
    }
}
