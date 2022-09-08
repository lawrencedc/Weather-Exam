using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_console.Services
{
    public class AnswerSelection
    {
        public static bool Selections()
        {
            int optionsCount = 2;
            int selected = 0;
            bool done = false;

            while (!done)
            {
                for (int i = 0; i < optionsCount; i++)
                {
                    if (selected == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("> ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                    Console.WriteLine(i == 0 ? "Yes" : "No");
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selected = Math.Max(0, selected - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selected = Math.Min(optionsCount - 1, selected + 1);
                        break;
                    case ConsoleKey.Enter:
                        done = true;
                        break;
                }

                if (!done)
                    Console.CursorTop = Console.CursorTop - optionsCount;
            }

            return selected == 0 ? true : false;
        }
    }
}
