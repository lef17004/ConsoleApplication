using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("Where do you live? ");
            string location = Console.ReadLine();

            Console.WriteLine($"Your name is {name}!");
            Console.WriteLine($"You live in {location}!");

            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine($"Today is the {currentDateTime.ToLongDateString()}!");

            DateTime christmas = new DateTime(currentDateTime.Year, 12, 25);
            Console.WriteLine($"{(christmas - currentDateTime).Days} days until Christmas!");

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
                   woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                   glassArea + " square metres");



            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
