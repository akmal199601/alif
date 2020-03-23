using System;

namespace First_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=16.8,b=12.4,k = Math.Sqrt(a*b);
            Console.WriteLine(k);
            double A = 1.4,B = -5.5,C = 0.6, AC = A - C, BC = C - B;
            Console.WriteLine(AC);
            Console.WriteLine(BC);
            Console.WriteLine(AC+BC);
            double x1 = -6.2,x2 = 2.1, y1 = 5.2,y2 = 9.8,h = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            Console.WriteLine(h);
            int n = 41,w = n / 10, u = n % 10;
            Console.WriteLine(u+""+w);
            int g = 10985,m = g / 60;
            Console.WriteLine(m);
            int  e = 202, i = e % 7;
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
