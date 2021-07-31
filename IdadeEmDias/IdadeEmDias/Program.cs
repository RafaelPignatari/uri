using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeEmDias
{
    class Program
    {
        static void Processo(ref int[] output, int dias)
        {
            int count = 0;
            for (int i = 0; ; i++)
            {
                if (dias >= 365)
                {
                    dias -= 365;
                    count++;
                }
                else
                    break;
            }
            output[0] = count;
            count = 0;
            for (int i = 0; ; i++)
            {
                if (dias >= 30)
                {
                    dias -= 30;
                    count++;
                }
                else
                    break;
            }
            output[1] = count;
            output[2] = dias;
        }
        static void Main(string[] args)
        {
            int dias = 0;
            int[] output = new int[3];

            if (int.TryParse(Console.ReadLine(), out dias))
            {
                Processo(ref output, dias);
                Console.WriteLine(output[0] + " ano(s)");
                Console.WriteLine(output[1] + " mes(es)");
                Console.WriteLine(output[2] + " dia(s)");
            }
        }
    }
}
