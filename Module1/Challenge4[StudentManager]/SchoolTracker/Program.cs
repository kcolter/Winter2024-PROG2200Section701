using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());
            var masterArray = new string[studentCount, studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name: ");
                masterArray[i, 0] = Console.ReadLine();

                Console.Write("Student Grade: ");
                masterArray[i, 1] = Console.ReadLine();
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", masterArray[i, 0], masterArray[i, 1]);
            }
        }
    }
}
