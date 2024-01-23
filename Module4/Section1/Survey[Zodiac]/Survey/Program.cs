using System;

namespace Survey
{

    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer();

            var day = getDayOfMonth();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("You were born on {0} {1}", month, day);
            Console.WriteLine("Your zodiac sign is {0}", GetZodiacSign(month, day));
        }
        
        static string GetZodiacSign(string monthIn, int date)
        {
            //source: fed chatgpt a list of zodiac months/dates and had it gen this switch statement,
            //as given the amount of repetitive typing felt it wasnt worth the time it'd take to write it by hand
            switch (monthIn.ToLower())
            {
                case "march":
                    return (date >= 21 && date <= 31) ? "Aries" : "Invalid date";
                case "april":
                    return (date >= 1 && date <= 19) ? "Aries" : (date >= 20 && date <= 30) ? "Taurus" : "Invalid date";
                case "may":
                    return (date >= 1 && date <= 20) ? "Taurus" : (date >= 21 && date <= 31) ? "Gemini" : "Invalid date";
                case "june":
                    return (date >= 1 && date <= 20) ? "Gemini" : (date >= 21 && date <= 30) ? "Cancer" : "Invalid date";
                case "july":
                    return (date >= 1 && date <= 22) ? "Cancer" : (date >= 23 && date <= 31) ? "Leo" : "Invalid date";
                case "august":
                    return (date >= 1 && date <= 22) ? "Leo" : (date >= 23 && date <= 31) ? "Virgo" : "Invalid date";
                case "september":
                    return (date >= 1 && date <= 22) ? "Virgo" : (date >= 23 && date <= 30) ? "Libra" : "Invalid date";
                case "october":
                    return (date >= 1 && date <= 22) ? "Libra" : (date >= 23 && date <= 31) ? "Scorpio" : "Invalid date";
                case "november":
                    return (date >= 1 && date <= 21) ? "Scorpio" : (date >= 22 && date <= 30) ? "Sagittarius" : "Invalid date";
                case "december":
                    return (date >= 1 && date <= 21) ? "Sagittarius" : (date >= 22 && date <= 31) ? "Capricorn" : "Invalid date";
                case "january":
                    return (date >= 1 && date <= 19) ? "Capricorn" : (date >= 20 && date <= 31) ? "Aquarius" : "Invalid date";
                case "february":
                    return (date >= 1 && date <= 18) ? "Aquarius" : (date >= 19 && date <= 29) ? "Pisces" : "Invalid date";
                default:
                    return "Invalid month";
            }
        }

        static int getDayOfMonth()
        {
                Console.WriteLine("Please enter the day of the month you were born on:");
                string input = Console.ReadLine();
                int day;

                //!TryParse so will loop until something valid is parsed
                while (!(int.TryParse(input, out day))) //only validating that it is a number, no other validation req in doc. 
                {
                    Console.WriteLine("Invalid entry, please enter the number of the day [1-31] you were born on");
                    input = Console.ReadLine();

                }
                return day;
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }
    }
}

