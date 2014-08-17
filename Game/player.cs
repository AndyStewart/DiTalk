using System;

namespace Game
{
    public class Player
    {
    	private Random random = new Random();

    	public int Move()
    	{
    		var moves = random.Next(6) + random.Next(6);
    		return moves;
    	}
    }
}
