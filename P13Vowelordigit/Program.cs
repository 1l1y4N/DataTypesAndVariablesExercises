using System;


namespace P13Vowelordigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine());

            if ((c >= '0') && (c <= '9'))
            {
                Console.WriteLine("digit");
            }
            else if ((c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'y') || (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'Y' || c == 'U' || c == 'u'))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
