using DBAssignment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBAssignment_1
{
    internal class StudentManager
    {
        StudentDbContext stdCtx = new StudentDbContext();
        internal void AddNewStudent()
        {
            string fname = Utility.GetInputFirstName();
            string lname = Utility.GetInputLastName();
            string city = Utility.GetInputCity();
            string program = Utility.GetInputProgram();
            stdCtx.Add(new Student(fname, lname, city, program));
            stdCtx.SaveChanges();
            Console.WriteLine("A new Student has been registered.");
        }
        internal void PrintAllStudents()
        {
            if (stdCtx.students != null)
            {
                foreach (var std in stdCtx.students)
                {
                    Console.WriteLine($"Name: {std.FName + " " + std.LName}         City: {std.City}        Program: {std.Program}          Status: {std.ToString()}");
                }
            }
            else
            {
                Console.WriteLine("No Data to Show!!!");
            }
        }
        internal void UpdateStudentData()
        {
            if (stdCtx.students != null)
            {
                Student? std = stdCtx.students.Where(s => s.FName == Menu.GetStudentToChange()).FirstOrDefault<Student>();
                if (std != null)
                {
                    switch (Menu.UpdateMenu())
                    {
                        case 1:
                            {
                                ChangeFirstName(std);
                            }
                            break;
                        case 2:
                            {
                                ChangeLastName(std);
                            }
                            break;
                        case 3:
                            {
                                ChangeCity(std);
                            }
                            break;
                        case 4:
                            {
                                ChangeProgram(std);
                            }
                            break;
                        case 5:
                            {
                                ChangeStatus(std);
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
        private void ChangeFirstName(Student std)
        {
            Console.WriteLine($"Current First Name: {std.FName}");
            std.FName = Utility.GetInputFirstName();
            stdCtx.SaveChanges();
        }
        private void ChangeLastName(Student std)
        {
            Console.WriteLine($"Current Last Name: {std.LName}");
            std.LName = Utility.GetInputLastName();
            stdCtx.SaveChanges();
        }
        private void ChangeCity(Student std)
        {
            Console.WriteLine($"Current City: {std.City}");
            std.City = Utility.GetInputCity();
            stdCtx.SaveChanges();
        }
        private void ChangeProgram(Student std)
        {
            Console.WriteLine($"Current Study Program: {std.Program}");
            std.Program = Utility.GetInputProgram();
            stdCtx.SaveChanges();
        }
        private void ChangeStatus(Student std)
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
            else if (input == "d" && std.IsActive)
            {
                std.IsActive = false;
            }
            stdCtx.SaveChanges();
        }
    }
}
