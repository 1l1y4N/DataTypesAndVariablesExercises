using System;


namespace P17PrintASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            byte startChar = byte.Parse(Console.ReadLine());
            byte endChar = byte.Parse(Console.ReadLine());

            for (int i = startChar; i <= endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
