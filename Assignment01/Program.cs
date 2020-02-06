using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables to be used
            int length = 0;
            int width = 0;
            bool cont = false;

            Console.WriteLine("Welcome");
            Console.WriteLine("Please enter the length and width of the rectangle.");
            do
            {
                try
                {
                    // Getting the input from the user for the Rectangle's length
                    Console.WriteLine("Length: ");
                    length = int.Parse(Console.ReadLine());
                    if (length > 0)
                    {
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a value greater than 0.");
                        cont = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    cont = true;
                }
            } while (cont == true);

            do
            {
                try
                {
                    // Getting the input from the user for the Rectangle's width
                    Console.WriteLine("Width: ");
                    width = int.Parse(Console.ReadLine());
                    if (width > 0)
                    {
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a value greater than 0.");
                        cont = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    cont = true;
                }
            } while (cont == true);

            // Creating a new object of the Rectangle class using parameterized constructor
            Rectangle rect = new Rectangle(length, width);

            do
            {
                try
                {
                    // Presenting a menu and getting input from the user for the same
                    Console.WriteLine("The Menu: \n1. Get Rectangle Length\n2. Change Rectangle Length\n3. Get Rectangle Width\n4. Change Rectangle Width\n5. Get Rectangle Perimeter\n6. Get Rectangle Area\n7. Exit");
                    var input = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    switch (input)
                    {
                        case 1:
                            Console.WriteLine(rect.GetLength());
                            cont = true;
                            break;
                        case 2:
                            do
                            {
                                try
                                {
                                    // Getting new Length for the Rectangle from the user
                                    Console.WriteLine("New Length: ");
                                    var input1 = int.Parse(Console.ReadLine());
                                    if (input1 > 1)
                                    {
                                        // Setting Length of the Rectangle
                                        rect.SetLength(input1);
                                        cont = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a value greater than 1");
                                        cont = true;
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    cont = true;
                                }
                            } while (cont == true);
                            cont = true;
                            break;
                        case 3:
                            Console.WriteLine(rect.GetWidth());
                            cont = true;
                            break;
                        case 4:
                            do
                            {
                                try
                                {
                                    // Getting new Width for the Rectangle from the user
                                    Console.WriteLine("New Width: ");
                                    var input1 = int.Parse(Console.ReadLine());
                                    if (input1 > 1)
                                    {
                                        // Setting Width of the Rectangle
                                        rect.SetWidth(input1);
                                        cont = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a value greater than 1");
                                        cont = true;
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    cont = true;
                                }
                            } while (cont == true);
                            cont = true;
                            break;
                        case 5:
                            // Getting perimeter of the Rectangle
                            Console.WriteLine(rect.GetPerimeter());
                            cont = true;
                            break;
                        case 6:
                            // Getting Area of the Rectangle
                            Console.WriteLine(rect.GetArea());
                            cont = true;
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input!");
                            cont = true;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    cont = true;
                }
            } while (cont == true);
        }
    }
}
