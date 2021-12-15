using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_12HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Длина окружности = {0:F3}", Circle.Length(radius));

            Console.WriteLine("Площадь круга = {0:F3}", Circle.Area(radius));

            Console.WriteLine("Введите координаты x и y искомой точки");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты x0 и y0 центра круга");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Circle.Include(x, y, x0, y0, radius);
            Console.ReadKey();
        }

        public static class Circle
        {
            public const double PI = 3.1415926535897931; // константа Пи, вместо ссылки на Math.PI KEKW
            public static double Length(double value)
            {
                return 2 * PI * value;
            }
            public static double Area(double value)
            {
                return PI * value * value;
            }
            public static void Include(double x, double y,
                                            double x0, double y0,
                                                double radius)
            {
                Console.Write("точка с координатами x={0} и y={1}", x, y);
                if (radius >= Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0)))
                {
                    Console.Write(" ПРИНАДЛЕЖИТ");
                }
                else
                {
                    Console.Write(" НЕ ПРИНАДЛЕЖИТ");
                }
                Console.WriteLine("кругу с радиусом {0}, расположенном на координатах x0={1} y0={2}", radius, x0, y0);
                ;
            }

        }
    }
}
