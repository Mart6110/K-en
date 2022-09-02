using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Køen
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            byte age;

            bool exit = false;
            ConsoleKeyInfo choice;

            // Creating a new object from our Menu class
            Menu menu = new Menu();

            // Creating a queue the has the datatype of our Guest class
            Queue<Guest> queue = new Queue<Guest>();

            do
            {
                // Showing how many there are in the queue
                menu.ShowMenu(queue.Count);

                // Reading our key press
                choice = Console.ReadKey();

                // A switch that look at the key pressed
                switch (choice.Key)
                {
                    // Adding a person to the queue
                    case ConsoleKey.D1:
                            Console.Clear();

                            Console.WriteLine("Enter your name:");
                            name = Console.ReadLine();

                            Console.WriteLine("Enter your age:");
                            age = byte.Parse(Console.ReadLine());
                            Guest guest = new Guest(name, age);
                            queue.Enqueue(guest);
                            break;

                    // Showing the first person in the queue
                    case ConsoleKey.D2:
                            Console.Clear();

                            Console.WriteLine("First person in queue: " + queue.Peek());

                            Console.WriteLine();
                            Console.WriteLine("Press 'Enter' to return to menu");
                            Console.ReadLine();
                            break;
                            
                    // Showing all persons in the queue
                    case ConsoleKey.D3:
                            Console.Clear();
                            Console.WriteLine("All people in queue:");
                            Console.WriteLine();

                            // Looping through the queue and writting out each person in the queue
                            foreach(Guest g in queue)
                            {
                                Console.WriteLine(g);
                                Console.WriteLine();
                            }

                            Console.WriteLine("Press 'Enter' to return to menu");
                            Console.ReadLine();
                            break;

                    // Exit the program
                    case ConsoleKey.D4:
                            exit = true;
                            break;

                    // If a Person press a key that we have not maked a case for
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Unknown Command.");
                        break;
                }
                Console.Clear();

            } while (exit != true);
        }
    }
}
