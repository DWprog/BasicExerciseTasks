using System;
using System.Collections.Generic;
using System.Globalization;

namespace BasicExerciseTasks.Tasks
{
    public class TaskContent : TaskBase
    {
        public void BirthDate()
        {
            SetTitle(
                "Napisz program, który pobiera od użytkownika datę urodzenia w formacie\n" +
                "dd.mm.rrrr"
                );
            SetDescription(
                "...i na jej podstawie wyświetla wiek oraz informację o tym, czy osob\n" +
                "a jest pełnoletnia czy nie. Program powinien uwzględniać rok bieżący oraz\n" +
                "dokładność na poziomie dni. Pełnoletniość jest osiągana w wieku 18 lat.\n" +
                "Program powinien wykorzystać instrukcję warunkową if-else oraz metody\n" +
                "klasy DateTime do operacji na datach."
                );
            SetAuthor("Adam Kamizelich");
            SetDate("24.03.2023");

            SetTaskHeader("Program oblicza pełnoletnoość na podstawie podanej daty");
            ShowHeader();

            while (true)
            {
                Console.Write("Podaj datę urodzin w formacie dd.mm.rrrr: ");
                var input = Console.ReadLine();

                if (input.ToLower() == QuitButton)
                {
                    Console.WriteLine();
                    break;
                }

                if (DateTime.TryParseExact(input, "d", new CultureInfo("de-DE"), DateTimeStyles.None, out DateTime dateOfBirth))
                {
                    var today = DateTime.Now;
                    var age = new DateTime(today.Ticks - dateOfBirth.Ticks);

                    Console.WriteLine($"Dzisiaj jest: {today.Day.ToString("D2")}.{today.Month.ToString("D2")}.{today.Year}");

                    if (age.Year - 1 >= 18)
                    {
                        Console.WriteLine($"Jesteś osobą pełnoletnią. Masz już {age.Year - 1} lat, {age.Month - 1} miesięcy i {age.Day - 1} dni");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Nie jesteś osobą pełnoletnią. Masz tylko {age.Year - 1} lat, {age.Month - 1} miesięcy i {age.Day - 1} dni");
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("Błędny format daty");
                }
            }
        }

        public void AllInReverseOrder()
        {
            SetTitle(
                "Napisz program w C# który przyjmie w konsoli jedną liczbę, a następnie\n+" +
                "wyświetli wszystkie liczby...r"
                );
            SetDescription(
                "..w odwrotnej kolejności odliczając do zera.\n" +
                "Np.dla 3:\n" +
                "3\n" +
                "2\n" +
                "1\n" +
                "0"
                );
            SetAuthor("Adam Kamizelich");
            SetDate("10.02.2023");

            SetTaskHeader("Program wyświetla wszystkie liczby naturalne w dół od zadanej");
            ShowHeader();

            while (true)
            {
                WriteText("Podaj liczbę naturalną: ", ConsoleColor.DarkGreen);
                var input = Console.ReadLine();

                if (input.ToLower() == QuitButton)
                {
                    Console.WriteLine();
                    break;
                }

                if (int.TryParse(input, out int number) && number >= 0)
                {
                    for (int i = number; i >= 0; i--)
                    {
                        Console.WriteLine($"{i}");
                    }
                }

                else
                {
                    WriteText("To nie jest liczba naturalna!\n", ConsoleColor.Red);
                }
            }
        }

        public void SimpleCalculator()
        {
            SetTitle(
                "Napisz program w języku C#, który będzie prostym kalkulatorem"
                );
            SetDescription(
                "Program zapyta o dwie liczy oraz o operację jaką ma na nich wykonać.\n" + "" +
                "np:\n" +
                "3\n" +
                "5\n" +
                "+\n" +
                "============\n" +
                "wynik: 8"
                );
            SetAuthor("Adam Kamizelich");
            SetDate("10.02.2023");

            SetTaskHeader("Prosty kalkulator - tylko operacje + - * /");
            ShowHeader();

            while (true)
            {
                WriteText("Podaj pierwszą liczbę: ", ConsoleColor.DarkGreen);
                var input1 = Console.ReadLine();
                WriteText("Podaj drugą liczbę: ", ConsoleColor.DarkGreen);
                var input2 = Console.ReadLine();

                if (input1.ToLower() == QuitButton || input2.ToLower() == QuitButton)
                {
                    Console.WriteLine();
                    break;
                }

                if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
                {
                    WriteText("Co chcesz zrobić + - * /: ", ConsoleColor.DarkCyan);
                    var iuserChoice = Console.ReadLine();

                    Console.WriteLine("====================");

                    switch (iuserChoice)
                    {
                        case "+":
                            Console.WriteLine($"{(double)number1 + number2}\n");
                            break;
                        case "-":
                            Console.WriteLine($"{(double)number1 - number2}\n");
                            break;
                        case "*":
                            Console.WriteLine($"{(double)number1 * number2:N4}\n");
                            break;
                        case "/":
                            if (number2 != 0)
                            {
                                Console.WriteLine($"{(double)number1 / number2:N4}\n");
                            }
                            else
                            {
                                WriteText("Nie można dzielić przez zero!\n\n", ConsoleColor.Red);
                            }
                            break;

                        default:
                            WriteText("Błędny wybór działania\n\n", ConsoleColor.Red);
                            break;
                    }
                }

                else
                {
                    WriteText("To nie są poprawne liczby!\n", ConsoleColor.Red);
                }
            }


        }

        public void Factorial()
        {
            SetTitle(
                "Napisz program, który pobiera od użytkownika liczbę całkowitą i oblicza\n" +
                "jej silnię"
                );
            SetDescription(
                "Silnia n! dla liczby n jest równa iloczynowi wszystkich liczb naturalnych\n" +
                "od 1 do n, czyli n! = 1 * 2 * 3 * ... * n. Program powinien wykorzystać\n" +
                "pętlę for lub rekurencję."
                );
            SetAuthor("Adam Kamizelich");
            SetDate("24.03.2023");

            SetTaskHeader("Program liczy silnię z podanej liczby");
            ShowHeader();

            while (true)
            {
                WriteText("Podaj liczbę naturalną: ", ConsoleColor.DarkGreen);
                var input = Console.ReadLine();

                if (input.ToLower() == QuitButton)
                {
                    Console.WriteLine();
                    break;
                }

                if (int.TryParse(input, out int number) && number > 0 && number <= 22)
                {
                    ulong result = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        result *= (ulong)i;
                    }
                    WriteText("Wartość silni z pętli: ", ConsoleColor.Green);
                    WriteText($"{result:N0}\n");

                    ulong FactorialRecursively(int intNumber)
                    {
                        if (intNumber < 2)
                            return 1;
                        return (ulong)intNumber * FactorialRecursively(intNumber - 1);
                    }

                    WriteText("Wartość silni z rekurencji: ", ConsoleColor.Green);
                    WriteText($"{FactorialRecursively(number):N0}\n\n");
                }

                else
                {
                    WriteText("To nie jest liczba naturalna lub liczba jest większa od 22!\n", ConsoleColor.Red);
                }
            }
        }

        public void NumberPositiveNegativeEqualZero()
        {
            SetTitle(
                "Napisz program w C#, który sprawdzi, czy liczba jest dodatnia, ujemna\n" +
                "lub równa zero"
                );
            SetDescription("");
            SetAuthor("Adam Kamizelich");
            SetDate("04.02.2023");

            SetTaskHeader("Program sprawdza znak liczby");
            ShowHeader();

            while (true)
            {
                WriteText("Podaj liczbę: ", ConsoleColor.DarkGreen);
                var input = Console.ReadLine();

                if (input.ToLower() == QuitButton)
                {
                    Console.WriteLine();
                    break;
                }

                if (double.TryParse(input, out double number))
                {
                    if (number > 0)
                    {
                        WriteText("Liczba jest dodatnia\n\n", ConsoleColor.Green);
                    }
                    else if (number < 0)
                    {
                        WriteText("Liczba jest ujemna\n\n", ConsoleColor.Green);
                    }
                    else
                    {
                        WriteText("Liczba jest równa zeru\n\n", ConsoleColor.Green);
                    }
                }

                else
                {
                    WriteText("To nie jest liczba!\n", ConsoleColor.Red);
                }
            }
        }

        public void StringAnalysis()
        {
            SetTitle(
                "Napisz program który przyjmie ciąg znaków i zwróci analizę ile razy\n" +
                "występują poszczególne litery"
                );
            SetDescription("");
            SetAuthor("Adam Kamizelich");
            SetDate("10.02.2023");

            SetTaskHeader("Program zlicza występowanie liter w tekście");
            ShowHeader();


            while (true)
            {
                WriteText("Wpisz tekst do przeanalizowania\n", ConsoleColor.DarkGreen);
                var text = Console.ReadLine().ToLower();

                if (text == QuitButton)
                {
                    Console.WriteLine();
                    break;
                }

                if (text != "")
                {
                    List<char> letters = new();
                    foreach (var letter in text)
                    {
                        if (Char.IsLetter(letter))
                        {
                            letters.Add(letter);
                        }
                    }
                    letters.Sort();

                    int count = 0;
                    int sum = 0;
                    int no = 0;
                    char current = letters[0];
                    for (int i = 0; i < letters.Count; i++)
                    {
                        sum++;
                        if (letters[i] == current)
                        {
                            count++;
                        }
                        else
                        {
                            no++;
                            WriteText($"{no}. {current} = {count}\n", ConsoleColor.Cyan);
                            count = 1;
                            current = letters[i];
                        }
                        if (i == letters.Count - 1)
                        {
                            no++;
                            WriteText($"{no}. {current} = {count}\n", ConsoleColor.Cyan);
                            WriteText($"Razem liter = {sum}\n", ConsoleColor.Magenta);
                        }
                    }
                    Console.WriteLine();
                }

                else
                {
                    WriteText("Tekst jest pusty!\n", ConsoleColor.Red);
                }
            }
        }

        public void TemperatureDegreeConversion()
        {
            SetTitle(
                "Napisz program w C# do zamiany stopni Celcjusza na Farenheita\n" +
                "i odwrotnie"
                );
            SetDescription("");
            SetAuthor("Adam Kamizelich");
            SetDate("07.02.2023");

            SetTaskHeader("Program zamienia stopnie temperatury");
            ShowHeader();

            while (true)
            {
                WriteText("Konwersja Celsjusz --> Farenheit ");
                WriteText("CF\n", ConsoleColor.Green);
                WriteText("Konswrsja Farenheit --> Celsjusz ");
                WriteText("FC\n", ConsoleColor.Green);

                WriteText("Wybierz konwersję: ", ConsoleColor.DarkGreen);
                var choice = Console.ReadLine();
                choice = choice.ToLower();

                if (choice == QuitButton)
                {
                    Console.WriteLine();
                    break;
                }

                switch (choice)
                {
                    case "cf":
                        WriteText("Podaj wartość temperatury w stopniach Celsjusza: ", ConsoleColor.DarkCyan);
                        var inputC = Console.ReadLine();

                        if (double.TryParse(inputC, out double degreeC) && degreeC >= -273.15)
                        {
                            WriteText($"{degreeC} stopni Celsjusza to ");
                            WriteText($"{degreeC * 1.8 + 32:N2}", ConsoleColor.Yellow);
                            WriteText($" stopni Farenheita\n\n");
                        }
                        else
                        {
                            WriteText("Zła wartość temperatury\n", ConsoleColor.Red);
                        }
                        break;

                    case "fc":
                        WriteText("Podaj wartość temperatury w stopniach Farenheita: ", ConsoleColor.DarkCyan);
                        var inputF = Console.ReadLine();

                        if (double.TryParse(inputF, out double degreeF) && degreeF >= -459.67)
                        {
                            WriteText($"{degreeF} stopni Farenhieta to ");
                            WriteText($"{(degreeF - 32) / 1.8:N2}", ConsoleColor.Yellow);
                            WriteText($" stopni Celsjusza\n\n");
                        }
                        else
                        {
                            WriteText("Zła wartość temperatury\n", ConsoleColor.Red);
                        }
                        break;

                    default:
                        WriteText("Niepoprawny wybór!\n", ConsoleColor.Red);
                        continue;
                }
            }
        }

        public void NameOfDayOfWeek()
        {
            SetTitle(
                "Napisz program w C#, który na podstawie numeru dnia tygodnia wydrukuje\n" +
                "jego nazwę"
                );
            SetDescription("");
            SetAuthor("Adam Kamizelich");
            SetDate("07.02.2023");

            SetTaskHeader("Program wyświetla nazwę dnia tygodnia na podstawie liczby");
            ShowHeader();

            string[] daysOfWeek = new string[]{"poniedziałek", "wtorek","środa","czwartek",
            "piątek","sobota","niedziela"};

            while (true)
            {
                WriteText("Podaj liczbę do wyświetlenia dnia tygodnia: ", ConsoleColor.DarkGreen);
                var input = Console.ReadLine();

                if (input.ToLower() == QuitButton)
                {
                    Console.WriteLine();
                    break;
                }

                if (int.TryParse(input, out int number) && number > 0 && number <= 7)
                {
                    WriteText($"Liczba {number} to ");
                    WriteText($"{daysOfWeek[number - 1]}\n\n", ConsoleColor.Green);
                }

                else
                {
                    WriteText("Błędna wartość!\n", ConsoleColor.Red);
                }
            }
        }

        public void GuessNumber()
        {
            SetTitle(
                "Napisz program w C# \"Gra w zgadywanie liczby\" (if else, pętle)"
                );
            SetDescription(
                "Twoim zadaniem jest napisać prostą grę, w której komputer losuje liczbę\n" +
                "z przedziału od 1 do 100, a użytkownik ma za zadanie zgadnąć tę liczbę.\n" +
                "Komputer powinien udzielać podpowiedzi, czy podana liczba jest za duża,\n" +
                "za mała czy właściwa."
                );
            SetAuthor("Zuzia");
            SetDate("12.05.2023");

            SetTaskHeader("Gra w zgadywanie liczby");
            ShowHeader();

            Random random = new Random();

            while (true)
            {
                WriteText("Zgadnij liczbę z zakresu od 1 do 100\n", ConsoleColor.DarkYellow);
                int unknown = random.Next(1, 101);
                int count = 0;
                bool isNewGame = true;

                while (isNewGame)
                {
                    WriteText($"Podaj swoją próbę: ", ConsoleColor.DarkCyan);
                    var input = Console.ReadLine();

                    if (input.ToLower() == QuitButton)
                    {
                        Console.WriteLine();
                        return;
                    }

                    if (int.TryParse(input, out int number) && number >= 1 && number <= 100)
                    {
                        count++;
                        if (number > unknown)
                        {
                            WriteText("Za duża!\n", ConsoleColor.Green);
                            continue;
                        }
                        else if (number < unknown)
                        {
                            WriteText("Za mała!\n", ConsoleColor.Red);
                            continue;
                        }
                        else
                        {
                            WriteText($"Gratulacje! Zgadłeś liczbę {unknown}. Liczba prób: ");
                            WriteText($"{count}\n\n", ConsoleColor.Magenta);
                            isNewGame = false;
                            Console.ReadKey();
                        }
                    }

                    else
                    {
                        WriteText("Błędna wartość!\n", ConsoleColor.Red);
                    }

                }
            }
        }

        public void RemoveDuplicatesFromArray()
        {
            SetTitle(
                "Napisz program w języku C#, który usunie wszystkie zduplikowane liczby\n" +
                "z podanej tablicy"
                );
            SetDescription("");
            SetAuthor("Adam Kamizelich");
            SetDate("04.03.2023");

            SetTaskHeader("Program usuwa duplikaty z podanej tablicy liczb");
            ShowHeader();

            while (true)
            {
                WriteText("Podaj wielkość tablicy: ", ConsoleColor.DarkYellow);
                var sizeOfArray = Console.ReadLine();

                if (sizeOfArray.ToLower() == QuitButton)
                {
                    Console.WriteLine();
                    return;
                }

                if (int.TryParse(sizeOfArray, out int size) && size > 0)
                {
                    double[] array = new double[size];
                    int indexOfArray = 0;

                    while (true)
                    {
                        WriteText($"Podaj liczbę nr {indexOfArray + 1} z {size}: ", ConsoleColor.DarkCyan);
                        var input = Console.ReadLine();

                        if (input.ToLower() == QuitButton)
                        {
                            Console.WriteLine();
                            return;
                        }

                        if (double.TryParse(input, out double number))
                        {
                            array[indexOfArray] = number;
                            indexOfArray++;

                            if (indexOfArray >= size)
                            {
                                double[] uniques = TaskFunctions.ArrayWithoutDuplicate(array);

                                WriteText("Unikatowe liczby:\n");
                                foreach (var unique in uniques)
                                {
                                    WriteText($"{unique}  ", ConsoleColor.Magenta);
                                }
                                Console.WriteLine("\n");
                                break;
                            }
                        }

                        else
                        {
                            WriteText("To nie jest liczba!\n", ConsoleColor.Red);
                        }
                    }
                }

                else
                {
                    WriteText("Wielkość tablicy musi być liczbą naturalną!\n", ConsoleColor.Red);
                    continue;
                }
            }
        }
    }
}
