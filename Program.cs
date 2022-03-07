using System;

namespace lab6_generics
{
    class Trapezoid<T>
        where T : struct
    {
        private T _a { get; set; }
        public T A
        {
            set
            {
                if (Convert.ToDouble((dynamic)value) < 0)
                {
                    throw new Exception("Не может быть меньше нуля");
                }
                _a = value;
            }
            get { return _a; }
        }
        private T _b { get; set; }
        public T B
        {
            set
            {
                if (Convert.ToDouble((dynamic)value) < 0)
                    throw new Exception("Не может быть меньше нуля");
                _b = value;
            }
            get { return _b; }
        }
        private T _h { get; set; }
        public T H
        {
            set
            {
                if (Convert.ToDouble((dynamic)value) < 0)
                    throw new Exception("Не может быть меньше нуля");
                _h = value;
            }
            get { return _h; }
        }

        public Trapezoid(T a, T b, T h)
        {
            A = a;
            B = b;
            H = h;
        }
        public double Square()
        {
            return ((dynamic)A + (dynamic)B) / 2 * (dynamic)H;

        }
        public override string ToString()
        {
            return $"A: {A}, B: {B}, Высота:{H}, Площадь: {Square()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var trapInt = new Trapezoid<int>(3, 7, 9);
            var trapUInt = new Trapezoid<uint>(6, 9, 14);
            var trapDouble = new Trapezoid<double>(2.4, 3.7, 4.2);
            Console.WriteLine($"Int: {trapInt}");
            Console.WriteLine($"uInt: {trapUInt}");
            Console.WriteLine($"Double: {trapDouble}");
        }
    }
}
