using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            const double rende = 12;
            double tempo = 0;
            double velocidade = 0;

            if (double.TryParse(Console.ReadLine(), out tempo))
                if (double.TryParse(Console.ReadLine(), out velocidade))
                    Console.WriteLine(((velocidade * tempo) / rende).ToString("0.000"));
        }
    }
}
