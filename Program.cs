namespace DBAssignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            var student = new Student();
            var stdContext = new StudenDB();
            int UserChoice = Menu.MainMenu();
            MenuChoice menuChoice = (MenuChoice)UserChoice;
            switch (menuChoice)
            {
                case MenuChoice.AddNew:
                    var std = student.AddNewStudent();
                    stdContext.Add(std);
                    stdContext.SaveChanges();
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
