using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAssignment_1
{
    internal class Student
    {
        public int StudentId { get; set; }
        internal string FName { get; set; } = string.Empty;
        internal string LName { get; set; }= string.Empty;
        internal string City { get; set; } = string.Empty;
        internal string Program {  get; set; } = string.Empty;
        internal bool IsActive { get; set; } = true;

        public Student()
        {
            
        }
        public Student(string fName, string lName, string city, string program)
        {
            FName = fName;
            LName = lName;
            City = city;
            Program = program;

        }
    }
}
