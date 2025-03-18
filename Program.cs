using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the day of the week number (1-7): ");

        if (int.TryParse(Console.ReadLine(), out int dayNumber))
        {
            string dayName = dayNumber switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Error: Please enter a number between 1 and 7!"
            };

            Console.WriteLine(dayName);
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid number!");
        }
    }
}
