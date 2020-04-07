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
			long maxn = 0;
			long terms = 1;
			long maxterms = 1;
			long[] maxarr = new long[2000];
			
			long limit = 1000000;
			while(n<limit)
			{
				if(Array.Exists(maxarr, element => element==n)==true) goto JUMP;
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
					maxterms = terms;
					maxn = n;
					calculn = n;
					maxarr[0] = calculn;
					for(long i=1; i<maxterms; i++)
					{
						if(calculn%2==0) calculn/=2;
						else if(calculn!=1)
						{
							calculn=(calculn*3)+1;
						}
						maxarr[i]=calculn;
					}
				}
				terms=1;
				JUMP: n++;				
			}
			Console.WriteLine("sequence starts from : " + maxn + "\n" + "terms : " + maxterms);
			for(long i=0; i<=maxarr.Length-1; i++)
			{
				if(maxarr[i]!=0) Console.Write(maxarr[i]+" ");
			}
		}
	}
}