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
        Delete = 3, 
        PrintAll = 4, 
        CloseProgram =5
    }
    internal static class Menu
    {

        internal static int MainMenu()
        {

            Console.WriteLine("!!! Student Register !!!");
            Console.WriteLine("" +
                "1- Register new student in Database.\n" +
                "2- Change data for an existing student.\n" +
                "3- Delete a student from Database.\n" +
                "4- Display a list of all registered students.\n" +
                "5- Close the program.");
            Console.Write("Choose Task from above to perform: ");
            int choice = Utility.GetIntInput();
            return choice;


        }
        



    }
}
