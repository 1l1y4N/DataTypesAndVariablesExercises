using System;


namespace P16ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            Console.WriteLine((Math.Abs(a - b) < eps));
        }
    }
}
