using System;

namespace Lab5 {

    class Program
    {
        abstract class Shape
        {
            void GetArea() { }

        }
        class Paralelogram : Shape
        {
            public void GetArea()
            {
                double a, h;
                Console.WriteLine("Enter values for A,H");
                a = Convert.ToDouble(Console.ReadLine());
                h = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Area of Paralelogram is: "+ a * h);
            }

        }
        class Trapezium : Shape
        {
            public void GetArea()
            {
                double c, d, h;
                Console.WriteLine("Enter values for C,D,H");
                c = Convert.ToDouble(Console.ReadLine());
                d = Convert.ToDouble(Console.ReadLine());
                h = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Area of Trapezia is: "+ ((0.5 * (c + d)) * h));
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Лабораторна робота №5 на тему: <Застосування концепції повторного використання класів при розробці додатків> ");
            Console.WriteLine("");
            Console.WriteLine("Варiант №3");
            Console.WriteLine("");
            Console.WriteLine("Виконав:Харченко Максим Олександрович");
            Console.WriteLine("");
            Console.WriteLine("Група: ЕС-137Бстн");
            Console.WriteLine("");
            Paralelogram paralelogram = new Paralelogram{ };
            Trapezium trapezium = new Trapezium { };
            paralelogram.GetArea();
            trapezium.GetArea();
          


        }
    }
}

