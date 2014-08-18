using System;

namespace Game
{
    public class Player
    {
    	private Random random = new Random();
    	private int position;

    	public int Position
    	{
			get 
			{
				return position;
			}
    	}

    	public void TakeTurn()
    	{
    		var result = random.Next(6) + random.Next(6);
    		this.position = (this.position + result) % 40;
    	}
    }
}
