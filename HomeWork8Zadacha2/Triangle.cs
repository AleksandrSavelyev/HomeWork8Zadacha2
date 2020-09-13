using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8Zadacha2
{
    class Triangle
    {
        private int a, b, c;
        public Triangle() { }
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int A
        {
            get { return a; }
            set { a = value; }

        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public int C
        {
            get { return c; }
            set { c = value; }
        }
        public bool IsTriangle
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                return false;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"сторона AB={a} сторона BC={b} сторона CA={c}");
        }
        public string GetPerimetr()
        {
            int P = a + b + c;
            return $"периметр треугольника рвен {P}";
        }
        public string GetArea()
        {
            double x = a + b + c;
            double Ppolu = x / 2;
            double S = Math.Sqrt(Ppolu * (Ppolu - a) * (Ppolu - b) * (Ppolu - c));
            return $"площадь треугольника равна {S}";
        }
    }
}

        
    

