﻿using System;


namespace P8EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long pId = long.Parse(Console.ReadLine());
            int uniqueEmployeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + pId);
            Console.WriteLine("Unique Employee number: " + uniqueEmployeeNumber);
        }
    }
}
