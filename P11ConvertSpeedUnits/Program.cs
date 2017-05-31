using System;


namespace P11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F7}", distance / (((hours * 60.0) * 60.0) + (minutes * 60.0) + seconds));
            Console.WriteLine(("{0:F7}", distance /);
        }
    }
}
