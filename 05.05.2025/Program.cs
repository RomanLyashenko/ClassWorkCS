using System;

namespace _05._05._2025
{
    internal class Program
    {
        public class Rectangle
        {
            private int width;
            private int height;

            public Rectangle()
            {
                Console.Write("Enter the width of the rectangle: ");
                this.width = int.Parse(Console.ReadLine());
                Console.Write("Enter the height of the rectangle: ");
                this.height = int.Parse(Console.ReadLine());
            }

            public void Draw()
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        public class Rhombus
        {
            private int width;
            private int height;

            public Rhombus()
            {
                Console.Write("Enter the width of the rhombus: ");
                this.width = int.Parse(Console.ReadLine());
                Console.Write("Enter the height of the rhombus: ");
                this.height = int.Parse(Console.ReadLine());
            }

            public void Draw()
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height - i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < width + (2 * i); j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int i = height - 2; i >= 0; i--)
                {
                    for (int j = 0; j < height - i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < width + (2 * i); j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        public class Triangle
        {
            private int width;
            private int height;

            public Triangle()
            {
                Console.Write("Enter the base width of the triangle: ");
                this.width = int.Parse(Console.ReadLine());
                Console.Write("Enter the height of the triangle: ");
                this.height = int.Parse(Console.ReadLine());
            }

            public void Draw()
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height - i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (2 * i + 1); j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        public class Trapezoid
        {
            private int topWidth;
            private int bottomWidth;
            private int height;

            public Trapezoid()
            {
                Console.Write("Enter the width of the top side of the trapezoid: ");
                this.topWidth = int.Parse(Console.ReadLine());
                Console.Write("Enter the width of the bottom side of the trapezoid: ");
                this.bottomWidth = int.Parse(Console.ReadLine());
                Console.Write("Enter the height of the trapezoid: ");
                this.height = int.Parse(Console.ReadLine());
            }

            public void Draw()
            {
                int widthDifference = bottomWidth - topWidth;

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height - i - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    int currentWidth = topWidth + (widthDifference * i) / height;

                    for (int j = 0; j < currentWidth; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            // task 1
            while (true)
            {
                Console.WriteLine("Choose a figure:\n1 - Rectangle\n2 - Rhombus\n3 - Triangle\n4 - Trapezoid\n5 - Exit\nYour choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                if (choice == 5) break;

                switch (choice)
                {
                    case 1:
                        Rectangle rectangle = new Rectangle();
                        rectangle.Draw();
                        break;

                    case 2:
                        Rhombus rhombus = new Rhombus();
                        rhombus.Draw();
                        break;

                    case 3:
                        Triangle triangle = new Triangle();
                        triangle.Draw();
                        break;

                    case 4:
                        Trapezoid trapezoid = new Trapezoid();
                        trapezoid.Draw();
                        break;

                    default:
                        break;
                }

                Console.WriteLine(new string('-', 20));
            }

            // task 2

           
        }
    }
}