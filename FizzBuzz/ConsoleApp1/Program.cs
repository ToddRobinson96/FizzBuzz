using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter Maximum Number:");
			string maxNumberString = Console.ReadLine();						// Read entered string	
			int maxNumber;
			bool success = int.TryParse(maxNumberString, out maxNumber);		// Convert to integer if we can
			if (success == false)
			{
				Console.WriteLine("You did not enter an integer");				// Catch non-integers
				goto ExitLabel;
			}

			Console.Write("Would you like to use the Fizz rule? (Y or N)");
			string fizzResponse = Console.ReadLine();
			if ((fizzResponse != "Y") && (fizzResponse != "N"))
			{
				Console.WriteLine("You did not enter Y or N");              // Catch answers not Y or N
				goto ExitLabel;
			}

			Console.Write("Would you like to use the Buzz rule? (Y or N)");
			string buzzResponse = Console.ReadLine();
			if ((buzzResponse != "Y") && (buzzResponse != "N"))
			{
				Console.WriteLine("You did not enter Y or N");              // Catch answers not Y or N
				goto ExitLabel;
			}

			Console.Write("Would you like to use the Fezz rule? (Y or N)");
			string fezzResponse = Console.ReadLine();
			if ((fezzResponse != "Y") && (fezzResponse != "N"))
			{
				Console.WriteLine("You did not enter Y or N");              // Catch answers not Y or N
				goto ExitLabel;
			}

			Console.Write("Would you like to use the Bang rule? (Y or N)");
			string bangResponse = Console.ReadLine();
			if ((fizzResponse != "Y") && (fizzResponse != "N"))
			{
				Console.WriteLine("You did not enter Y or N");              // Catch answers not Y or N
				goto ExitLabel;
			}

			Console.Write("Would you like to use the Bong rule? (Y or N)");
			string bongResponse = Console.ReadLine();
			if ((bongResponse != "Y") && (bongResponse != "N"))
			{
				Console.WriteLine("You did not enter Y or N");              // Catch answers not Y or N
				goto ExitLabel;
			}

			Dictionary<int, string> words = new Dictionary<int, string>(); // Create dictionary of the primes and corresponding words
				words.Add(3, "Fizz");
				words.Add(5, "Buzz");
				words.Add(7, "Bang");
				words.Add(11, "Bong");
				words.Add(13, "Fezz");

			Dictionary<int, string> responses = new Dictionary<int, string>(); // Create dictionary of the primes and corresponding words
			responses.Add(3, fizzResponse);
			responses.Add(5, buzzResponse);
			responses.Add(7, bangResponse);
			responses.Add(11, bongResponse);
			responses.Add(13, fezzResponse);

			for (int i = 1; i <= maxNumber; i++)
			{
				List<string> wordList = new List<string>();						// We build a list of the words

				int[] numbers = { 3, 5, 7 };
				foreach (int j in numbers)
				{
					if ((i % j == 0) && (responses[i] == "Y"))
					{
						wordList.Add(words[j]);								// For 3, 5 and 7 add the word to the end
					}
				}
				if ((i % 11 == 0) && (responses[11] == "Y"))
				{
					wordList.Clear();
					wordList.Add(words[11]);		// For 11, clear the word and write Bong
				}
				if ((i % 13 == 0) && (responses[13] == "Y"))
				{
					wordList.Insert(0, words[13]);	//Add Fezz to start if 0 mod 13
				}
				if (i % 17 == 0) 
				{
					wordList.Reverse();				// For 17, reverse the order 
				}
				if (wordList.Count == 0)
				{
					string iString = i.ToString();
					wordList.Add(iString);			// If not caught above, print number.
				}
				string message = string.Join("", wordList.ToArray());	// Create a string from our list
				Console.WriteLine(message);								// Print message
			}
			ExitLabel:
			Console.ReadLine();
		}
	}
}
