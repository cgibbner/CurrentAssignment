using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int zip;
            double salary;
            double taxes;

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Hex Is Best v1.0");
            Console.WriteLine("");

            Console.WriteLine("Thank you for choosing the Hexagon Technologies - Hex Is Best - software.");
            Console.WriteLine("The industry standard for pre-program launch welcome messages.");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Please enter software developer's name:");
            Console.Write(" --> ");

            name = Console.ReadLine();

            Console.WriteLine("Please enter software developers ZIP code:");
            Console.Write(" --> ");

            zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter software developers monthly gross pay:");
            Console.Write(" --> ");

            salary = Convert.ToDouble(Console.ReadLine());

            taxes = (salary * 1.07);
            Console.WriteLine(taxes);
            taxes = (taxes - salary);

            Console.WriteLine(name);
            Console.WriteLine(zip);
            Console.WriteLine(salary);
            Console.WriteLine(taxes);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
