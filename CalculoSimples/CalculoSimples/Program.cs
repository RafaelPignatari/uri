using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSimples
{
    class Program
    {
        static float Pagar(string input)
        {
            float preco = 0;
            int qtd = 0;

            input = input.Remove(0, (input.IndexOf(' ') + 1));
            qtd = Convert.ToInt32(input.Substring(0, input.IndexOf(' ')));
            input = input.Remove(0, (input.IndexOf(' ') + 1));
            preco = float.Parse(input);
            return (preco * qtd);
        }
        static void Main(string[] args)
        {
            float total = 0;
            string[] input = new string[2];

            input[0] = Console.ReadLine();
            input[1] = Console.ReadLine();

            total = (Pagar(input[0]) + Pagar(input[1]));
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("0.00"));
        }
    }
}
