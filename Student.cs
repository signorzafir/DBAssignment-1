using Microsoft.IdentityModel.Tokens;
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
        public string LName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Program { get; set; } = string.Empty;
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
        internal void AddNewStudent()
        {
            var stdContext = new StudenDB();
            string fname = Utility.GetInputFirstName();
            string lname = Utility.GetInputLastName();
            string city = Utility.GetInputCity();
            string program = Utility.GetInputProgram();
            stdContext.Add(new Student(fname, lname, city, program));
            stdContext.SaveChanges();
            Console.WriteLine("A new Student has been registered.");
        }
        internal void PrintAllStudents()
        {
            var stdContext = new StudenDB();
            if (stdContext.students != null)
            {
                foreach (var std in stdContext.students)
                {
                    Console.WriteLine($"Name: {std.FName + " " + std.LName}         City: {std.City}        Program: {std.Program}          Status: {std.ToString()}");
                }
            }
            else
            {
                Console.WriteLine("No Data to Show!!!");
            }
        }

        public override string? ToString()
        {
            if (IsActive)
            {
                return "Active";
            }
            else
            {
                return "Inactive";
            }
        }
        internal void UpdateStudentData()
        {
            var stdContext = new StudenDB();
            string studentToChange;
            int userChoice;
            Console.WriteLine("Enter student you want to change.");
            studentToChange = Utility.GetInputFirstName();
            Console.WriteLine("1- To change First Name.\n" +
                "2- To change Last Name\n" +
                "3- To change City.\n" +
                "4- To change Study Program\n" +
                "5- To Activate / Deactivate a student");
            userChoice = Utility.GetIntInput();
            if (stdContext.students != null)
            {
                var std = stdContext.students.Where(s => s.FName == studentToChange).FirstOrDefault<Student>();
                if (std != null)
                {
                    switch (userChoice)
                    {
                        case 1:
                            {
                                Console.WriteLine($"Current First Name: {std.FName}");
                                std.FName = Utility.GetInputFirstName();
                                stdContext.SaveChanges();
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine($"Current Last Name: {std.LName}");
                                std.LName = Utility.GetInputLastName();
                                stdContext.SaveChanges();
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine($"Current City: {std.City}");
                                std.City = Utility.GetInputCity();
                                stdContext.SaveChanges();
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine($"Current Study Program: {std.Program}");
                                std.Program = Utility.GetInputProgram();
                                stdContext.SaveChanges();
                            }
                            break;
                        case 5:
                            {
                                string input;
                                Console.WriteLine($"Student {std.FName} {std.LName} is {std.ToString()}");
                                if (!std.IsActive)
                                {
                                    Console.Write("\nEnter \"A\" to Confirm Activation : ");
                                }
                                else if (std.IsActive)
                                {
                                    Console.Write("\nEnter \"D\" to Confirm Deactivation : ");
                                }
                                input = Utility.GetStringInput().ToLower();
                                
                                if (input == "a" && !std.IsActive)
                                {
                                    std.IsActive = true;
                                }
                                else if (input  == "d" && std.IsActive)
                                {
                                    std.IsActive = false;
                                }
                                stdContext.SaveChanges();
                            }
                            break;

                        default:
                            break;
                    }

                    Console.WriteLine($"\nStudent data for {std.FName} {std.LName} has been updated in Student Register.\n");
                }
                else
                {
                    Console.WriteLine("No matched record found!!!");
                }
            }
            else
            {
                Console.WriteLine("No matched record found!!!");
            }
        }
        internal void DeativateStudent()
        {

        }
    }
}
