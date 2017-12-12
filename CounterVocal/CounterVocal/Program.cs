using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterVocal
{
	class Program
	{
		static void Main(string[] args)
		{
			string phrase = string.Empty;
			int sum = 0;
			int sumA = 0, sumE = 0, sumI = 0, sumO = 0, sumU = 0;    

			Console.WriteLine("Enter a phrase");
			phrase = Console.ReadLine().ToLower();
			int length = phrase.Length;

			for (int i = 0; i < length; i++)
			{   
				if (phrase[i] == 'a' || phrase[i] == 'á')
				{
					sum++;
					sumA++;
				}

				if (phrase[i] == 'e' || phrase[i] == 'é')
				{
					sum++;
					sumE++;
				}

				if (phrase[i] == 'i' || phrase[i] == 'í')
				{
					sum++;
					sumI++;
				}

				if (phrase[i] == 'o' || phrase[i] == 'ó')
				{
					sum++;
					sumO++;
				}
				if (phrase[i] == 'u' || phrase[i] == 'ú')
				{
					sum++;
					sumU++;
				}
			}
				
			Console.WriteLine("The number of 'a' is: " + sumA);
			Console.WriteLine("The number of 'e' is: " + sumE);
			Console.WriteLine("The number of 'i' is: " + sumI);
			Console.WriteLine("The number of 'o' is: " + sumO);
			Console.WriteLine("The number of 'u' is: " + sumU);
			Console.ReadKey();

			string message = "The number of total vocal is: " + sum;
			for(int x = 0; x <= Console.BufferWidth - message.Length; x++)
			{
				System.Threading.Thread.Sleep(100);
				Console.Clear();
				Console.SetCursorPosition(x, 0);
				Console.WriteLine(message);
			}

		}
	}
}
