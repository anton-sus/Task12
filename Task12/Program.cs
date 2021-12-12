using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("введите R, x, y:");
            Circle.Circumference();
            Circle.Area();
            Circle.Point();

            Console.ReadKey();
        }
    }
    static class Circle
    {
        static int rad = Convert.ToInt32(Console.ReadLine());
        static int x = Convert.ToInt32(Console.ReadLine());
        static int y = Convert.ToInt32(Console.ReadLine());

        public static void Circumference()
        {
            double c = 2 * Math.PI * rad;
            Console.WriteLine("длина окружности = {0:f2}", c);
        }
        public static void Area()
        {
            double a = Math.PI * Math.Pow(rad, 2);
            Console.WriteLine("площадь = {0:f2}", a);
        }
        public static void Point()
        {
            if (rad == Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)))
            {
                Console.WriteLine("точка ({0},{1}) принадлежит кругу с радиусом {2}", x, y, rad);
            }
            else
            {
                Console.WriteLine("точка с координатами ({0},{1}) не принадлежит кругу с радиусом {2}", x, y, rad);
            }
        }
    }
}
