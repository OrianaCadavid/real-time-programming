using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListPersons
{
    class Program
    {
        static void Main(string[] args)
        {
            int employees = 0;

            Console.WriteLine("Enter the number of employees");
            employees = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[employees];
            int[] age = new int[employees];



            for (int i = 0; i < employees; i++)
            {
                Console.WriteLine("Enter the name and then the age of the employees");
                names[i] = Console.ReadLine();
                age[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Employees are:");
            for (int i = 0; i < employees; i++)
            {

                Console.WriteLine(names[i] + "   ");

            }

            Console.ReadKey();
        }
    }
}
