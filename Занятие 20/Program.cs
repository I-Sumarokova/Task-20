using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_20
{
    class Program
    {
        delegate double MyDelegate(double r);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус R");
            double r = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate = new MyDelegate(Dlina);
            double l = myDelegate(r);
            Console.WriteLine(l);

            MyDelegate myDelegate1 = new MyDelegate(Area);
            double s = myDelegate1(r);
            Console.WriteLine(s);

            MyDelegate myDelegate2 = new MyDelegate(Volume);
            double v = myDelegate2(r);
            Console.WriteLine(v);

            Console.ReadKey();
        }

        static double Dlina (double r)
        {
            Console.WriteLine("Длина окружности:");
            double l = 2*Math.PI*r;
            return l;
        }
        static double Area(double r)
        {
            Console.WriteLine();
            Console.WriteLine("Площадь круга:");
            double s = Math.PI * Math.Pow(r,2);
            return s;
        }
        static double Volume(double r)
        {
            Console.WriteLine();
            Console.WriteLine("Объем шара:");
            double v = (4.0/3)*Math.PI * Math.Pow(r, 3);
            return v;
        }

    }
}
