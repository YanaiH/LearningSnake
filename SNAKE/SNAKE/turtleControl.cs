using System;
using Unit4.TurtleLib;
using System.Drawing;

namespace learningSnakeV2
{
    class turtleControl
    {
        static void Main2()
        {
            Turtle trtl = new Turtle();
            trtl.TailDown();
            while (true)
            {
                double direction = trtl.GetHeading();
                
                ConsoleKey keyPress = Console.ReadKey().Key;
                switch (keyPress)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            switch (direction)
                            {
                                case 0:
                                    {
                                        trtl.TurnLeft(90);
                                        break;
                                    }
                                case 270:
                                    {
                                        trtl.TurnLeft(180);
                                        break;
                                    }
                                case 180:
                                    {
                                        trtl.TurnRight(90);
                                        break;
                                    }
                                case 90:
                                    {
                                        break;
                                    }
                                default:
                                    break;
                            }
                            trtl.MoveForward(5);
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            switch (direction)
                            {
                                case 0:
                                    {
                                        trtl.TurnRight(90);
                                        break;
                                    }
                                case 270:
                                    {
                                        break;
                                    }
                                case 180:
                                    {
                                        trtl.TurnLeft(90);
                                        break;
                                    }
                                case 90:
                                    {
                                        trtl.TurnRight(180);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            trtl.MoveForward(5);
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            switch (direction)
                            {
                                case 0:
                                    {
                                        break;
                                    }
                                case 270:
                                    {
                                        trtl.TurnLeft(90);
                                        break;
                                    }
                                case 180:
                                    {
                                        trtl.TurnRight(180);
                                        break;
                                    }
                                case 90:
                                    {
                                        trtl.TurnRight(90);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            trtl.MoveForward(5);
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            switch (direction)
                            {
                                case 0:
                                    {
                                        trtl.TurnLeft(180);
                                        break;
                                    }
                                case 270:
                                    {
                                        trtl.TurnRight(90);
                                        break;
                                    }
                                case 180:
                                    {
                                        break;
                                    }
                                case 90:
                                    {
                                        trtl.TurnLeft(90);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            trtl.MoveForward(5);
                            break;
                        }
                    case ConsoleKey.U:
                        {
                            trtl.TailUp();
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            trtl.TailDown();
                            break;
                        }
                    case ConsoleKey.C:
                        {
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                
            }
        }

        static void Main1() // testing
        {
            Turtle test = new Turtle();
            test.TurnRight(90);
            Console.WriteLine(test.GetHeading());
            Console.ReadKey();
        }
    }
}
