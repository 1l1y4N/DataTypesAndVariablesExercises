using System;


namespace P7ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int oldA = b;
            int oldB = a;
            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}\r\nAfter:\r\na = {oldA}\r\nb = {oldB}");
        }
    }
}
