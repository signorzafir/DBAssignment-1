using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAssignment_1
{
    internal class Student
    {
        internal int id { get; set; }
        internal string FName { get; set; } = "";
        internal string LName { get; set; } = "";
        public Student(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }
    }
}
