using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{

    interface IPayee
    {
        void Pay();
    }

    internal class PayRoll
    {
        List<IPayee> payees = new List<IPayee>();

        Teacher t1 = new Teacher();
        Teacher t2 = new Teacher();
        Principal p1 = new Principal();

        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }
        

        public void PayAll()
        {
            foreach (var item in payees)
            {
                item.Pay();
            }
        }
    }
}
