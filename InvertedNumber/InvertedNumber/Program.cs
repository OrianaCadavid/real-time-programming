using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertedNumber
{
	class Program
	{
		static void Main(string[] args)
		{

			int number1 = 0;
			int number2 = 0;
			Console.WriteLine("Enter two numbers");
			number1 = Convert.ToInt32(Console.ReadLine());
			number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(Convert.ToString(number2) + number1);

			Console.ReadKey();
		}
	}
}
