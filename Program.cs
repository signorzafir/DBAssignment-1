﻿namespace DBAssignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int UserChoice = Menu.MainMenu();
            MenuChoice menuChoice = (MenuChoice)UserChoice;
            switch (menuChoice)
            {
                case MenuChoice.AddNew:
                    break;
                case MenuChoice.ChangeData:
                    break;
                case MenuChoice.Delete:
                    break;
                case MenuChoice.PrintAll:
                    break;
                case MenuChoice.CloseProgram:
                    break;
                default:
                    break;
            }
        }
    }
}
