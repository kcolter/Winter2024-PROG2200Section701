﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            Console.WriteLine("What is your quest?");
            var quest = Console.ReadLine();

            Console.WriteLine("What is your favorite colour?");
            var colour = Console.ReadLine();


            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Your birth month is {0}", month);
            Console.WriteLine("Your quest is {0}", quest);
            Console.WriteLine("Your favorite colour is {0}", colour);
        }
    }
}
