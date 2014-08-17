using System;

namespace Game
{
	class Program
	{
		static void Main(string[] args)
		{
			var player = new Player();
			var moves = player.Move();

			Console.WriteLine(String.Format("Player moved {0} spaces.", moves));
		}
	}
}
