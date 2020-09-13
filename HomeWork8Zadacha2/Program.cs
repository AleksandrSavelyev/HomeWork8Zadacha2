using System;

namespace HomeWork8Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            for (; ; )
            {
                Console.Write("введите сторону AB:\t");
                t.A = NumVal();
                Console.Write("введите сторону BC:\t");
                t.B = NumVal();
                Console.Write("введите сторону CA:\t");
                t.C = NumVal();
                if (t.IsTriangle)
                    break;
                else
                    Console.WriteLine("не существует треугольника с такими длиннами сторон\nвведите стороны заново:");
            }
            t.GetInfo();
            Console.WriteLine(t.GetPerimetr());
            Console.WriteLine(t.GetArea());
        }
        static int NumVal()
        {
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int b))
                    return b;
                else
                    Console.Write("неверные данные! повторите ввод:\t");
            }
        }
    }
}
