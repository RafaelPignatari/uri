using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void FormatInput (out double a, out double b, out double c, string input)
        {
            string[] aux = input.Split(' ');

            a = Convert.ToDouble(aux[0]);
            b = Convert.ToDouble(aux[1]);
            c = Convert.ToDouble(aux[2]);
        }
        static void Main(string[] args)
        {
            string input;
            double a = 0, b = 0, c = 0;
            const double pi = 3.14159;

            input = Console.ReadLine();
            FormatInput(out a,out b,out c, input);
            Console.WriteLine("TRIANGULO: " + ((a * c) / 2.0).ToString("0.000"));
            Console.WriteLine("CIRCULO: " + (pi*(c*c)).ToString("0.000"));
            Console.WriteLine("TRAPEZIO: " + ((b+a)*c/2.0).ToString("0.000"));
            Console.WriteLine("QUADRADO: " + (b*b).ToString("0.000"));
            Console.WriteLine("RETANGULO: " + (a*b).ToString("0.000"));
        }
    }
}
