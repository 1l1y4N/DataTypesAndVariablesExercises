using System;


namespace P14InttoHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            String hexNum = Convert.ToString(num, 16);
            hexNum = hexNum.ToUpper();
            String binNum = Convert.ToString(num, 2);

            Console.WriteLine("{0}\n{1}", hexNum, binNum);
        }
    }
}
