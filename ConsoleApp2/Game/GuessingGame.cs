using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Game
{
	internal class GuessingGame
	{

		static void Main(string[] args)
		{
			String answer = "Hello";
			String guess = "";

			int guessLimit = 3;
			int guessCount = 0;

			bool outofGuesses = false;

			while (guess != answer && !outofGuesses)
			{
				if(guessCount < guessLimit)
				{
					Console.WriteLine("Enter guess: ");
					guess = Console.ReadLine();
					guessCount++;
				} else
				{
					outofGuesses = true;
				}
			}

			if (outofGuesses)
			{
				Console.WriteLine("You Lose");
			} else
			{
				Console.WriteLine("You Won");
			}
		}

	}
}
