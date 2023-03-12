using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Thast
{
    internal class Program
    {

        private static void Print(object a)
        {
            Console.WriteLine(a.ToString());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("тест цилиндра\nВведите значения");
            Console.WriteLine("Координаты центра окружности");
            string[] a = (Console.ReadLine().Split(' ')); 
            Point v = new Point(int.Parse(a[0]), int.Parse(a[1]));
            Console.WriteLine("Координаты точки на окружности");
            a = (Console.ReadLine().Split(' '));
            Point b = new Point(int.Parse(a[0]), int.Parse(a[1]));
            Console.WriteLine("высота");
            int height = int.Parse(Console.ReadLine());
            Cylinder cylinder = new Cylinder(v , b , height);
            Console.WriteLine("Площадь основания");
            Print(cylinder.GetBaseArea());
            Console.WriteLine("Длинна окружности");
            Print(cylinder.GetLine());
            Console.WriteLine("Площадь боковой поверности");
            Print(cylinder.GetCircleSideSurface());
            Console.WriteLine("Объем");
            Print(cylinder.GetVolume());

            Console.WriteLine("тест треугольной призмы\nВведите значения");
            Console.WriteLine("точка 1");
            a = Console.ReadLine().Split(' ');
            b = new Point(int.Parse(a[0]), int.Parse(a[1]));
            Console.WriteLine("точка 2");
            a = Console.ReadLine().Split(' ');
            v = new Point(int.Parse(a[0]), int.Parse(a[1]));
            Console.WriteLine("точка 3");
            a = Console.ReadLine().Split(' ');
            Point k = new Point(int.Parse(a[0]), int.Parse(a[1]));
            Console.WriteLine("высота");
            height = int.Parse(Console.ReadLine());
            _3Prizma prizma = new _3Prizma(v , b ,k , height);
            Console.WriteLine("Площадь основания");
            Print(prizma.GetBaseArea());
            Console.WriteLine("периметр");
            Print(prizma.GetLine());
            Console.WriteLine("Площадь боковой поверности");
            Print(prizma.GetCircleSideSurface());
            Console.WriteLine("Объем");
            Print(prizma.GetVolume());

            Console.WriteLine("Тест 4-хугольной призмы\nВведите значения");
            Console.WriteLine("точка 1");
            a = Console.ReadLine().Split(' ');
            b = new Point(int.Parse(a[0]), int.Parse(a[1]));
            Console.WriteLine("точка 2");
            a = Console.ReadLine().Split(' ');
            v = new Point(int.Parse(a[0]), int.Parse(a[1]));
            Console.WriteLine("точка 3");
            a = Console.ReadLine().Split(' ');
            k = new Point(int.Parse(a[0]), int.Parse(a[1]));
            Console.WriteLine("точка 4");
            a = Console.ReadLine().Split(' ');
            Point m = new Point(int.Parse(a[0]), int.Parse(a[1]));
            Console.WriteLine("высота");
            height = int.Parse(Console.ReadLine());
            _4Prizma prizma2 = new _4Prizma( b, v, k, m, height);
            Console.WriteLine("Площадь основания");
            Print(prizma2.GetBaseArea());
            Console.WriteLine("периметр");
            Print(prizma2.GetLine());
            Console.WriteLine("Площадь боковой поверности");
            Print(prizma2.GetCircleSideSurface());
            Console.WriteLine("Объем");
            Print(prizma2.GetVolume());
            Console.WriteLine("Проверка на является призма параллелепипедом");
            Print(prizma2.GetParallalepiped());
            Console.WriteLine("Проверка на является ли призма прямоугольными параллелепипедом");
            Print(prizma2.GetPrimoiParallalepiped());
            Console.WriteLine("Проверка на является ли призма кубом");
            Print(prizma2.GetKub());
            Print("Вот и конец");
            Console.ReadKey();
        }
    }
}
