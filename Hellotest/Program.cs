using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Hellotest
{
	class Program
	{
		static void Main(string[] args)
		{
			Random randomGen = new Random();
			bool gameOn = true;
			int userGuess;
			int randomNumber = randomGen.Next(1, 11);


			while (gameOn == true)
			{
				Console.WriteLine("Hello! I'm thinking of a number between 1 and 10. Can you guess it?");

				try
				{
					userGuess = int.Parse(Console.ReadLine());

					if (userGuess == randomNumber)
					{
						Console.WriteLine("you win!");
						Console.WriteLine("Do you want to play again? Press any key to play again, press N to exit");
						string keepPlaying = Console.ReadLine().ToUpper();
						if (keepPlaying == "N")
						{
							Console.WriteLine("bye!");
							gameOn = false;
							System.Environment.Exit(0);
						}
						else
						{
							randomNumber = randomGen.Next(1, 11);
							continue;
						}

					}
					if (userGuess > randomNumber)
					{
						Console.WriteLine("Ooh, you're too high. Try again");
					}
					else if (userGuess < randomNumber)
					{
						Console.WriteLine("You're too low! try again.");
					}

				}
				catch
				{
					Console.WriteLine("oh no that was a bad guess. Try again");
				}
			}
		}
	}
}
