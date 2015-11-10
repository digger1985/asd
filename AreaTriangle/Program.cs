using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, S;
            Console.WriteLine("Сторона А :");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сторона B :");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сторона C :");
            c = Convert.ToDouble(Console.ReadLine());

            S = Area(a, b, c);

            Console.WriteLine("Площадь треугольника {0} :",S);
            Console.ReadKey();

        }

        public static double Area (double A , double B , double C)
        {
            double p, S;
            p = (A + B + C) / 2;

            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return S;
        }
    }
}
