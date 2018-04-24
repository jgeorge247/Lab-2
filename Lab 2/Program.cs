using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");

            Start:
            Console.WriteLine("Enter Length of Room (in ft): ");
            double Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width of Room (in ft): ");
            double Width = double.Parse(Console.ReadLine());

            double Area = Length * Width;
            double Perimeter = 2 * (Length + Width);

            Console.WriteLine("Area of Room = {0}", Area);
            Console.WriteLine("Perimeter of Room = {0}", Perimeter);

            Console.WriteLine("Continue? (y/n)");
            string response;
            response = Console.ReadLine();

            if (response == "y")
            {
                goto Start;
            }
            else
            {
                Console.WriteLine("Thanks!");
            }
     
        }
    }
}
