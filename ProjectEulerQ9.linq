<Query Kind="Program" />

/* A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.
There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc. */

namespace Solve
{
	class Q9
	{
		static void Main(string[] args)
		{
			int a, b, c;
			a=1;			
			int answer=1;
			
			while(answer==1)
			{
				b=a+1;			
				while(true)
				{
					c=(1000-(a+b));
					if(b>=c) break;
					if(a*a + b*b == c*c)
					{
						answer=a*b*c;
						break;
					}
					b++;
				}
				a++;
			}
		Console.WriteLine(answer);
		}
	}
}