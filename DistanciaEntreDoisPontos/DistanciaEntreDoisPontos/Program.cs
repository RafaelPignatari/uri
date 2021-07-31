using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaEntreDoisPontos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[2];
            double[] y = new double[2];
            string[] input1 = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');
            double distancia = 0;

            x[0] = Convert.ToDouble(input1[0]);
            y[0] = Convert.ToDouble(input1[1]);
            x[1] = Convert.ToDouble(input2[0]);
            y[1] = Convert.ToDouble(input2[1]);
            distancia = Math.Sqrt((Math.Pow((x[1] - x[0]), 2) + Math.Pow((y[1] - y[0]), 2)));
            Console.WriteLine(distancia.ToString("0.0000"));
        }
    }
}
