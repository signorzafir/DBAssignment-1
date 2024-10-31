using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAssignment_1
{
    internal static class Utility
    {

        public static int GetIntInput()
        {

            while (true)
            {
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int result))
                {
                    return result;
                }
                Console.WriteLine("Invalid input... please Enter only whole Numbers.");
            }
        }
        public static string GetStringInput()
        {

            while (true)
            {
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                Console.WriteLine("Invalid input...");
            }
        }
        public static string GetInputFirstName()
        {
            Console.Write("Enter First Name: ");
            string input = GetStringInput();
            return input;
        }
        public static string GetInputLastName()
        {
            Console.Write("Enter Last Name: ");
            string input = GetStringInput();
            return input;
        }

        public static void GoBackToMenu()
        {
            Console.Write("Press Enter to go back to Menu. ");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
