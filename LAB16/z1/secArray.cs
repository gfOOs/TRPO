using System;

public class secArray
{
	public secArray()
	{
		public int[,] intArray { get; set };
		
		public secArray(int n, int m)
		{
			this.intArray = new int[n, m];
		}
	}
}
