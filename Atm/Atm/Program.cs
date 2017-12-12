using System;

namespace Atm
{
	class MainClass
	{
		private static int totalAmount;

		private static void InitAmount() 
		{
			Console.Write("Enter amount of cash in ATM: ");
			try
			{
				totalAmount = Convert.ToInt32(Console.ReadLine());
			}
			catch (System.FormatException)
			{
				Console.WriteLine ("Enter a number please");
			}
		}

		private static void ShowMainMenu()
		{
			Console.Clear();
			Console.WriteLine("Oriana's ATM");
			Console.WriteLine("1. Withdraw cash");
			Console.WriteLine("0. Exit");
			Console.Write("> ");
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

		private static void ShowWithdrawMenu() {
			Console.Clear();
			Console.WriteLine("Withdraw cash (available: " + totalAmount + ")");
			Console.WriteLine("1. $10,000");
			Console.WriteLine("2. $20,000");
			Console.WriteLine("3. $50,000");
			Console.WriteLine("4. Another amount");
			Console.Write("> ");
		}

		private static int GetAmountToWithdraw()
		{
			int amount = -1;
			do {
				Console.Write ("Enter amount to withdraw (min $10,000. max $600,000): ");
				try {
					amount = Convert.ToInt32 (Console.ReadLine ());
					if (amount < 10000 || amount > 600000 || amount % 10000 != 0) {
						Console.WriteLine("Enter a valid amount please");
						amount = -1;
					}
						
				} catch (System.FormatException) {
					Console.WriteLine ("Enter a number please");
					amount = -1;
				}
			} while (amount == -1);
			return amount;
		}


		private static void Withdraw()
		{
			int option;
			do
			{
				ShowWithdrawMenu();
				option = GetUserOption (1, 4);

				if (option == -1)
				{
					Console.WriteLine("Select a valid option please");
					Console.ReadKey();
				}
			} while (option == -1);

			int amountToWithdraw = 0;
			switch (option) {
			case 1:
				amountToWithdraw = 10000;
				break;
			case 2:
				amountToWithdraw = 20000;
				break;
			case 3:
				amountToWithdraw = 50000;
				break;
			case 4:
				amountToWithdraw = GetAmountToWithdraw ();
				break;
			}

			if (amountToWithdraw > totalAmount) {
				Console.WriteLine ("There isn't enough cash in ATM, sorry :(");
				Console.ReadKey ();
			} else {
				totalAmount = totalAmount - amountToWithdraw;

				int numBanknotes50 = 0, numBanknotes20 = 0, numBanknotes10 = 0;
				if (amountToWithdraw > 50000) {
					int remainder = 0;
					if (amountToWithdraw % 50000 == 0) {
						remainder = 50000;
						amountToWithdraw -= 50000;
					} else {
						remainder = amountToWithdraw % 50000;
					}

					numBanknotes50 = amountToWithdraw / 50000;
					numBanknotes20 = remainder / 20000;
					remainder = remainder - 20000 * numBanknotes20;
					numBanknotes10 = remainder / 10000;
				} else if (amountToWithdraw < 50000) {
					numBanknotes20 = amountToWithdraw / 20000;
					amountToWithdraw = amountToWithdraw - 20000 * numBanknotes20;
					numBanknotes10 = amountToWithdraw / 10000;
				} else {
					numBanknotes50 = 1;
				}

				Console.WriteLine ("You withdrew $" + amountToWithdraw + " in:");
				Console.WriteLine ("    " + numBanknotes50 + " banknotes of $50,000:");
				Console.WriteLine ("    " + numBanknotes20 + " banknotes of $20,000:");
				Console.WriteLine ("    " + numBanknotes10 + " banknotes of $10,000:");
				Console.ReadKey ();
			}
		}

		private static void ExecuteOption(int option)
		{
			switch (option)
			{
			case 1: // Withdraw cash
				Withdraw();
				break;
			case 0: // Exit
				Console.Clear ();
				Console.WriteLine ("--- Bye ---");
				Environment.Exit (0);
				break;
			}
		}

		public static void Main(string[] args)
		{
			InitAmount();
			while (true)
			{
				int option;
				do
				{
					ShowMainMenu ();
					option = GetUserOption (0, 1);

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
