<Query Kind="Program" />

/* The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
Find the sum of all the primes below two million. */

namespace Solve
{
	class Q10
	{
		static void Main(string[] args)
		{
			int primeId=0;
			double sum=0;
			for(int i=1; i<2000000; i++)
			{
				for(int j=1; j<=i; j++)
				{
					if(i%j==0) primeId++;
					if(primeId>2) break;
				}
				if(primeId==2) sum+=i;
				primeId=0;
			}				
			Console.Write(sum);	
		}
	}
}