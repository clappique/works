<Query Kind="Program" />

/* The following iterative sequence is defined for the set of positive integers:
n → n/2 (n is even)
n → 3n + 1 (n is odd)
Using the rule above and starting with 13, we generate the following sequence:
13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
Which starting number, under one million, produces the longest chain?
NOTE: Once the chain starts the terms are allowed to go above one million. */

namespace Solve
{
	class Q14
	{
		static void Main(string[] args)
		{
			long n = 1;
			long calculn = 1;
			int maxn = 0;
			int terms = 1;
			int maxterms = 1;
						
			int limit = 1000000;
			while(n<limit)
			{
				calculn = n;
				while(calculn!=1)
				{
					if(calculn%2==0)
					{
						calculn/=2;
					}
					else if(calculn!=1)
					{
						calculn=(calculn*3)+1;
					}
					terms++;
				}
				if(terms>maxterms)
				{
					maxterms=terms;
					maxn = (int)n;
				}
				terms=1;
				n++;
			}
			Console.WriteLine("sequence starts from : " + maxn + "\n" + "terms : " + maxterms);			
		}
	}
}