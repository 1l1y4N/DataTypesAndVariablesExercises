using System;


namespace P5BooleanValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolValue = Console.ReadLine();
            bool toBool = Convert.ToBoolean(boolValue);
            if (toBool == true)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
        }
    }
}
