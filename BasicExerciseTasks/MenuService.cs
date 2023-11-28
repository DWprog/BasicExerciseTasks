using BasicExerciseTasks.Tasks;
using System;

namespace BasicExerciseTasks
{
    public class MenuService
    {
        protected static void ShowListOfTasks()
        {
            Console.WriteLine("Lista zrobionych zadań");
            Console.WriteLine("======================");
            WriteTask(1, "Pobieranie daty w formacie dd-mm-yyyy");
            WriteTask(2, "Wypisywanie liczb od  podanej liczby do zera");
            WriteTask(3, "Prosty kalkulator");
            WriteTask(4, "Silnia");
            WriteTask(5, "Sprawdzanie znaku liczby");
            WriteTask(6, "Zliczanie poszczególnych liter w tekście");
            WriteTask(7, "Zamiana stopni Celsjusza na Farenheita i odwrotnie");
            WriteTask(8, "Zamiana iczby na nazwę dnia tygodnia");
            WriteTask(9, "Zgadywanie liczby");

            Console.WriteLine();
            TaskBase.WriteText($"Aby zakończyć wbierz 0 (zero)\n\n", ConsoleColor.Black, ConsoleColor.Yellow);
        }


        protected static void ClearScreen(string choice)
        {
            Console.Clear();
            Console.WriteLine($"Zadanie {choice}:");
        }


        private static void WriteTask(int number, string content)
        {

            ConsoleColor clrNumber = ConsoleColor.Yellow;
            ConsoleColor clrContent = ConsoleColor.DarkCyan;

            TaskBase.WriteText($"{number}\t", clrNumber);

            var position = Console.GetCursorPosition();
            Console.SetCursorPosition(3, position.Top);

            TaskBase.WriteText(content, clrContent);
            Console.WriteLine();
        }
    }
}
