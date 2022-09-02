using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Menu
    {
        // Method
        public void ShowMenu( int guests)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("               Queue Operations Menu");
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine($"Guest in the queue: {guests}");
            Console.WriteLine();
            Console.WriteLine("1. Join Queue");
            Console.WriteLine("2. First in queue");
            Console.WriteLine("3. Show all in queue");
            Console.WriteLine("4. Exit program");
        }
    }
}
