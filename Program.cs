namespace DBAssignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            var stdContext = new StudentDbContext();
            int UserChoice;
            MenuChoice menuChoice;
            while (true)
            {

                UserChoice = Menu.MainMenu();
                menuChoice = (MenuChoice)UserChoice;
                switch (menuChoice)
                {
                    case MenuChoice.AddNew:
                        student.AddNewStudent();
                        Utility.GoBackToMenu();
                        break;
                    case MenuChoice.ChangeData:
                        student.UpdateStudentData();
                        Utility.GoBackToMenu();                        
                        break;
                    
                    case MenuChoice.PrintAll:
                        student.PrintAllStudents();
                        Utility.GoBackToMenu();
                        break;
                    case MenuChoice.CloseProgram:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Unknown Input !!!");
                        Utility.GoBackToMenu();

                        break;
                }

            }
        }
    }
}
