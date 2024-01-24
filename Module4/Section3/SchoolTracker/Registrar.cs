using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    internal class Registrar
    {
        List<IGraduate> studentList = new List<IGraduate>();

        public Registrar(List<IGraduate> gradListIn)
        {
            studentList = gradListIn;
        }

        public Registrar(List<Student> students)
        {
        }

        public void graduateAll()
        {
            foreach (var item in studentList)
            {
                item.graduate();
            }
        }


    }
}
