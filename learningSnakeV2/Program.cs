using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    class experiments
    {
        public static void input()
        {
            int xpos = Console.WindowWidth / 2, ypos = Console.WindowHeight / 2;
            Console.SetCursorPosition(xpos, ypos);
            while (true)
            {
                ConsoleKey keyInput = Console.ReadKey().Key;

                switch (keyInput)
                {
                    case ConsoleKey.RightArrow:
                        Console.Write(">");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.Write("<");
                        Console.SetCursorPosition(xpos - 1, ypos);
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Write("^");
                        Console.SetCursorPosition(xpos, ypos - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Write("v");
                        Console.SetCursorPosition(xpos, ypos + 1);
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.SetCursorPosition(xpos, ypos);
                        break;
                    default: break;

                }

                xpos = Console.CursorLeft;
                ypos = Console.CursorTop;
            }
        }

    }
    class Program
    {
        static void Main2(string[] args)
        {
            experiments.input();

        }

    }
}
