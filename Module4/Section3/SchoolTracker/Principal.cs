using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    internal class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying the Principal");
        }

    }
}
