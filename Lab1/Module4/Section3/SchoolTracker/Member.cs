﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    public class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }
}
