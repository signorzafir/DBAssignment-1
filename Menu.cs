using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAssignment_1
{
    enum MenuChoice
    {
        AddNew = 1,
        ChangeData = 2,
        PrintAll = 3,
        CloseProgram = 4
    }
    internal static class Menu
    {
        internal static int MainMenu()
        {
            Console.WriteLine("!!! Student Register !!!");
            Console.WriteLine("" +
                "1- Register new student in Database.\n" +
                "2- Change data for an existing student.\n" +
                "3- Display a list of all registered students.\n" +
                "4- Close the program.");
            Console.Write("Choose Task from above to perform: ");
            int choice = Utility.GetIntInput();
            return choice;
        }
        internal static int UpdateMenu()
        {
            while (true)
            {
                Console.WriteLine("1- To change First Name.\n" +
                    "2- To change Last Name\n" +
                    "3- To change City.\n" +
                    "4- To change Study Program\n" +
                    "5- To Activate / Deactivate a student");
                int input = Utility.GetIntInput();
                if (input > 0 && input < 6)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
            }
        }
        internal static string GetStudentToChange()
        {
            string studentToChange;
            Console.WriteLine("Enter student you want to change.");
            studentToChange = Utility.GetInputFirstName();
            return studentToChange;
        }
    }
}
