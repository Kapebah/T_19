using System;
using System.Collections.Generic;
using static System.Console;

namespace T19_1_hometask
{
    enum Action { Add = 1, Output, Exit }
    enum TypeOfShape { Triangle = 1, Rectangle, Circle, Exit }
    class ShapesRepository
    {
        List<Shapes> shapes = new List<Shapes>();

        public void WorkWithShapes()
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Choose an action: ");
            ResetColor();
            WriteLine("1 - Add a shape\n2 - Output all information about shapes\n3 - Exit");
            if (Enum.TryParse(ReadLine(), out Action action))
            {
                switch (action)
                {
                    case Action.Add:
                        Clear();
                        ForegroundColor = ConsoleColor.Yellow;
                        WriteLine("Choose a type of shape: ");
                        ResetColor();
                        WriteLine("1 - Triangle\n2 - Rectangle\n3 - Circle\n4 - Exit");
                        if (Enum.TryParse(ReadLine(), out TypeOfShape type))
                        {
                            switch (type)
                            {
                                case TypeOfShape.Triangle:
                                    Clear();
                                    shapes.Add(Triangle.Input());
                                    WriteLine();
                                    break;
                                case TypeOfShape.Rectangle:
                                    Clear();
                                    shapes.Add(Rectangle.Input());
                                    WriteLine();
                                    break;
                                case TypeOfShape.Circle:
                                    Clear();
                                    shapes.Add(Circle.Input());
                                    WriteLine();
                                    break;
                                case TypeOfShape.Exit:
                                    Environment.Exit(0);
                                    break;
                            }
                        }
                        else { ForegroundColor = ConsoleColor.Red; WriteLine("WRONG! Try again."); ResetColor(); }
                        break;
                    case Action.Output:
                        Clear();
                        ForegroundColor = ConsoleColor.Yellow;
                        WriteLine("All shapes: \n");
                        ResetColor();
                        foreach (var shape in shapes)
                        {
                            WriteLine(shape.ToString());
                            WriteLine();
                        }
                        break;
                    case Action.Exit:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
