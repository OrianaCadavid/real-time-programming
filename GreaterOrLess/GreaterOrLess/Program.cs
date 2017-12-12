using System;

namespace GreaterOrLess
{
	class MainClass
	{
		private static int a, b, c;
		private static int smallest, biggest;

		private static void ShowMainMenu()
		{
			Console.Clear();
			Console.WriteLine("Menu");
			Console.WriteLine("1. Show biggest number");
			Console.WriteLine("2. Show smallest number");
			Console.WriteLine("3. Exit ");
			Console.Write ("> ");
		}

		private static void FindSmallestAndBiggest() 
		{
			if (a > b && a > c && b > c)
			{
				biggest = a;
				smallest = c;
			}
			if (a > b && a > c && c > b)
			{
				biggest = a;
				smallest = b;
			}
			if (b > a && b > c && a > c)
			{
				biggest = b;
				smallest = c;
			}
			if (b > a && b > c && c > a)
			{
				biggest = b;
				smallest = a;
			}
			if (c > a && c > b && b > a)
			{
				biggest = c;
				smallest = a;
			}
			if (c > a && c > b && a > b)
			{
				biggest = c;
				smallest = b;
			}
		}

		private static void GetNumbers()
		{
			bool ok = false;
			do {
				Console.Clear();
				Console.WriteLine ("Enter three numbers:");
				try 
				{
					a = Convert.ToInt32 (Console.ReadLine ());
					b = Convert.ToInt32 (Console.ReadLine ());
					c = Convert.ToInt32 (Console.ReadLine ());
					ok = true;
				} 
				catch (System.FormatException) 
				{
					Console.WriteLine ("Enter only numbers please!!");
					Console.ReadKey ();
					ok = false;
				}
			} while (!ok);
		}

		private static int GetUserOption(int lower, int upper)
		{
			int option;
			try
			{
				option = Convert.ToInt32(Console.ReadLine());
				if (option >= lower && option <= upper)
					return option;
				else
					return -1;
			}
			catch (System.FormatException)
			{
				return -1;
			}
		}

		private static void ExecuteOption(int option) 
		{
			switch (option)
			{
			case 1: // Biggest
				Console.WriteLine ("The biggest number is " + biggest);
				Console.ReadKey ();
				break;
			case 2: // Smallest
				Console.WriteLine("The smallest number is " + smallest);
				Console.ReadKey ();
				break;
			case 3: // Exit
				Console.Clear ();
				Console.WriteLine ("--- Bye ---");
				Environment.Exit (0);
				break;
			}
		}

		public static void Main (string[] args)
		{
			
			GetNumbers ();
			FindSmallestAndBiggest ();
			while (true)
			{
				int option;
				do
				{
					ShowMainMenu ();
					option = GetUserOption (1, 3);

					if (option == -1)
					{
						Console.WriteLine("Select a valid option please");
						Console.ReadKey();
					}
				} while (option == -1);
				ExecuteOption(option);
			}
		}
	}
}

