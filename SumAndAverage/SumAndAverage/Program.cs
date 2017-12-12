﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverage
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1 = 0, number2 = 0;
			int i = 0;
			int sumpair = 0;
			int counterpair = 0;
			int averagepair = 0;
			int sumodd = 0;
			int counterodd = 0;
			int averageodd = 0;
			Console.WriteLine("Enter two numbers. The first number is the smallest value and seconds is the largest value ");
			number1 = Convert.ToInt32(Console.ReadLine());
			number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			for (i = number1; i <= number2; i++)
			{
				if (i % 2 == 0)
				{
					sumpair = sumpair + i;
					counterpair++;
				}
				else
				{
					sumodd = sumodd + i;
					counterodd++;
				}
				{

				}

			}


			averagepair = sumpair / counterpair;
			averageodd = sumodd / counterodd;

			Console.WriteLine("The average for even numbers is " + averagepair.ToString());
			Console.WriteLine("The average for odd numbers is " + averageodd.ToString());


			Console.ReadKey();

		}
	}
}