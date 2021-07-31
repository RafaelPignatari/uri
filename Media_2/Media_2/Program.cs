using System;

namespace Media_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;

            if (double.TryParse(Console.ReadLine(), out a))
                if (double.TryParse(Console.ReadLine(), out b))
                    if (double.TryParse(Console.ReadLine(), out c))
                        Console.WriteLine("MEDIA = " + (((a * 2) + (b * 3) + (c * 5)) / 10).ToString("0.0"));
        }
    }
}
