using System;

namespace URI_ConversaoHoras
{
    class Program
    {
        static string convert(int n)
        {
            string aux;
            int h = 0;
            int m = 0;
            if(n>=3600)
            {
                h = (n / 3600);
                n = (n-(h*3600));
            }
            if(n>=60)
            {
                m = (n / 60);
                n = (n - (m*60));
            }
            aux = Convert.ToString(h) +':' +Convert.ToString(m) +':' +Convert.ToString(n);
            return aux;
        }
        static void Main(string[] args)
        {
            int n = 0;
            string horas;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= 0)
                {
                    horas = convert(n);
                    Console.Write(horas +'\n');
                }
            }
            catch
            {

            }
        }     
    }
}
