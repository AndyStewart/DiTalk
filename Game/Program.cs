using System;

namespace Game
{
	class Program
	{
		static void Main(string[] args)
		{
			var playerOne = new Player();
			playerOne.TakeTurn();

			var playerTwo = new Player();
			playerTwo.TakeTurn();

			Console.WriteLine(String.Format("Player One position {0}.", playerOne.Position));
			Console.WriteLine(String.Format("Player Two position {0}.", playerTwo.Position));
		}
	}
}
