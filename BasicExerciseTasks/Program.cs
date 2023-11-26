using BasicExerciseTasks.Tasks;
using System;

namespace BasicExerciseTasks
{
    class Program : MenuService
    {
        static void Main(string[] args)
        {
            bool isClose = false;


            while (!isClose)
            {
                Console.Clear();
                ShowListOfTasks();

                TaskBase.WriteText($"Wybierz nr zadania: ", ConsoleColor.Green);
                var choice = Console.ReadLine();

                var task = new TaskContent();

                ClearScreen(choice);
                switch (choice)
                {
                    case "1":
                        task.BirthDate();
                        break;

                    case "2":
                        task.AllInReverseOrder();
                        break;

                    case "3":
                        task.SimpleCalculator();
                        break;

                    case "4":
                        task.Factorial();
                        break;

                    case "5":
                        task.NumberPositiveNegativeEqualZero();
                        break;

                    case "6":
                        task.StringAnalysis();
                        break;

                    case "7":
                        task.TemperatureDegreeConversion();
                        break;


                    case "0":
                        TaskBase.WriteText("Thank you for using\n", ConsoleColor.DarkYellow);
                        Console.WriteLine("To finish, press any key...");
                        Console.ReadKey();
                        isClose = true;
                        break;


                    default:
                        TaskBase.WriteText("Operation not allowed!\n\n", ConsoleColor.Red);
                        Console.ReadKey();
                        choice = "";
                        continue;
                }
            }
        }
    }
}
