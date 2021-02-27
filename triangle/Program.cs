using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t\t\t\tВведите два угла треугольника.");
            Console.Write("Введите первый целый неотрицательный угол: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второй целый неотрицательный угол: ");
            int b = int.Parse(Console.ReadLine());
            if (a + b <= 180)
            {
                if (a == 90 || b == 90 || a + b == 90)
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
                else
                {
                    Console.WriteLine("Треугольник непрямоугольный");
                }
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }



            Console.ReadLine();
        }
    }
}
