using System;
using System.Threading;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = "secret";
            var code = ""; //initialize code to empty string

            while(code != password)
            {
                Console.WriteLine("What is the pass code?");
                code = Console.ReadLine();

                if(code == password)
                {
                    Console.WriteLine("Authenticated.\n Would you like to update your passcode? [y/n]");
                    var response = Console.ReadLine();

                    if (response.ToLower() == "y")
                    {
                        Console.WriteLine("Please enter the new passcode. You'll be asked to re-verify after changing.");
                        password = Console.ReadLine(); //update password. this change will also cause our while to run again
                        continue; //restart loop
                    }
                    break;
                }
                Console.WriteLine("Not Authenticated.");
            }
        }
    }
}
