using System;

namespace SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario = 0, vendas = 0;

            nome = Console.ReadLine();
            if (double.TryParse(Console.ReadLine(), out salario))
                if (double.TryParse(Console.ReadLine(), out vendas))
                {
                    Console.WriteLine("TOTAL = R$ " + ((vendas * 0.15) + salario).ToString("0.00"));
                }
        }
    }
}
