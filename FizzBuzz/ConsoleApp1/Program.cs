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
			for (int i = 1; i <= 260; i++)
			{
				int modFive = i % 5;				//Perform Modulus calculations
				int modThree = i % 3;
				int modSeven = i % 7;
				int modEleven = i % 11;
				int modThirteen = i % 13;
				int modSeventeen = i % 17;

				string message = "";
				if (modThree == 0)
				{
					message = message + "Fizz";		//Add Fizz to end if 0 mod 3
				}
				if (modFive == 0)
				{
					message = message + "Buzz";		//Add Buzz to end if 0 mod 5
				}
				if (modSeven == 0)
				{
					message = message + "Bang";		//Add Bang to end if 0 mod 7
				}
				if (modEleven == 0)
				{
					message = "Bong";				//Message is Bong is 0 mod 11
				}
				if (modThirteen == 0)
				{
					message = "Fezz" + message;		//Add Fezz to start if 0 mod 13
				}
				if (modSeventeen == 0) 
				{
					string reorder = "";
					int messageLength = message.Length;
					int blocks = messageLength / 4;
					for (int j = 0; j < blocks; j++)
					{
						string chunk = message.Substring(4*j, 4);		// Take each four letter chunk
						reorder = chunk + reorder;						// Add the chunk to the start
					}
					message = reorder;
				}
				if (message == "")
				{
					message = i.ToString();			// If not caught above, print number.
				}
				Console.WriteLine(message);
			}
			Console.ReadLine();
		}
	}
}
