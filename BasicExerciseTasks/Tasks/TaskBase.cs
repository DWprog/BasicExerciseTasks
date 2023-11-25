using System;

namespace BasicExerciseTasks.Tasks
{
    public class TaskBase
    {
        protected string Title { get; private set; }
        protected string Description { get; private set; }
        protected string Author { get; private set; }
        protected string Date { get; private set; }

        protected string TaskHeader { get; private set; }


        protected const string QuitButton = "q";

        protected void ShowHeader()
        {
            string str = "";
            WriteText($"{Title}\n", ConsoleColor.Red);
            WriteText($"{Description}\n", ConsoleColor.Yellow);
            WriteText($"Autor: ");
            WriteText($"{Author} ", ConsoleColor.Cyan);
            WriteText($"{Date}\n\n", ConsoleColor.Green);

            WriteText($"   Aby zakończyć naciśnij \"{QuitButton.ToUpper()}\"   \n\n",
                ConsoleColor.Black, ConsoleColor.Cyan);

            WriteText($"{TaskHeader}\n");
            WriteText($"{str.PadLeft(TaskHeader.Length, '=')}\n\n");
        }

        protected void SetTitle(string title)
        {
            Title = title;
        }
        protected void SetDescription(string description)
        {
            Description = description;
        }
        protected void SetAuthor(string author)
        {
            Author = author;
        }
        protected void SetDate(string date)
        {
            Date = date;
        }
        protected void SetTaskHeader(string taskHeader)
        {
            TaskHeader = taskHeader;
        }

        public static void WriteText(string text,
            ConsoleColor colorForeground = ConsoleColor.Gray,
            ConsoleColor colorBackground = ConsoleColor.Black)
        {
            Console.ForegroundColor = colorForeground;
            Console.BackgroundColor = colorBackground;
            Console.Write($"{text}");
            Console.ResetColor();
        }
    }
}
