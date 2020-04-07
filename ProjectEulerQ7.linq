<Query Kind="Program" />

/* By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10 001st prime number? */

namespace Solve
{
	class Q7
	{
		static void Main(string[] args)
		{
			int primeCount=0;
			double i=1;
			int primeId=0;
			while(true)
			{
				for(int j=1; j<=i; j++)
					if(i%j==0) primeId++;
				if(primeId==2) primeCount++;				
				if(primeCount==10001) break;
				primeId=0;
				i++;
			}
			Console.Write(i);
		}
	}
}