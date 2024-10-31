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

        public string FName { get; set; } = string.Empty;
        public string LName { get; set; }= string.Empty;
        public string City { get; set; } = string.Empty;
        public string Program {  get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;


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
        internal Student AddNewStudent()
        {
            string fname = Utility.GetInputFirstName();
            string lname = Utility.GetInputLastName();
            string city = Utility.GetInputCity();
            string program = Utility.GetInputProgram();
            return new Student(fname, lname, city, program);
            



        }
    }
}
