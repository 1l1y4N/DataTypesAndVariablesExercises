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
            seconds += minutes * 60;
            seconds += hours * 3600;

            double mpsSpeed = distance / seconds;
            double kmpsSpeed = mpsSpeed * 3.60;
            double mphSpeed = kmpsSpeed * 0.621504;

            Console.WriteLine("{0:F6}\n{1:F5}\n{2:F5}", mpsSpeed, kmpsSpeed, mphSpeed);
        }
    }
}
