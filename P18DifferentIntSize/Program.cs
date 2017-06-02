using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18DifferentIntSize
{
    class Program
    {
        static void Main(string[] args)

        {
            String n = Console.ReadLine();
            try
            {
                long N = long.Parse(n);
                Console.WriteLine("{0} can fit in:", N);
                if ((N >= sbyte.MinValue) && (N <= sbyte.MaxValue))
                {
                    Console.WriteLine("* sbyte");
                }
                if ((N >= byte.MinValue) && (N <= byte.MaxValue))
                {
                    Console.WriteLine("* byte");
                }
                if ((N >= short.MinValue) && (N <= short.MaxValue))
                {
                    Console.WriteLine("* short");
                }
                if ((N >= ushort.MinValue) && (N <= ushort.MaxValue))
                {
                    Console.WriteLine("* ushort");
                }
                if ((N >= int.MinValue) && (N <= int.MaxValue))
                {
                    Console.WriteLine("* int");
                }
                if ((N >= uint.MinValue) && (N <= uint.MaxValue))
                {
                    Console.WriteLine("* uint");
                }
                Console.WriteLine("* long");
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} can't fit in any type", n);
            }
        }
    }
}
