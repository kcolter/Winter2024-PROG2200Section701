﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Survey
{
    internal class Stats
    {
        public void Start()
        {
            Program.Posted += HasPosted;
        }

        void HasPosted()
        {
            Console.WriteLine("Survey Posted, run start");
        }


    }
}
