using System;
using System.Collections.Generic;
using System.Text;

namespace Survey
{
    internal class Marketing
    {
    
        public void Start()
        {
            Program.SurveyDone += end;
        }

        public void end()
        {
            Console.WriteLine("Thank you for completing the survey. You are now subscribed to ten of our newsletters.");
        }
    
    }
}
