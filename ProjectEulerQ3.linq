<Query Kind="Program" />

/* The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ? */

namespace Solve
{
	class Q3
	{
		static void Main(string[] args)
		{
			long target = 600851475143;			
			long largest_primeFactor=0;
			long mult_Value=1;
			int count=0;			
			for(long i=2; i<=target; i++)
			{
				if(i<largest_primeFactor) continue;
				if(target%i==0)
				{
					for(int j=2; j<=i; j++)
					{
						if(i%j==0) count++;
						if(count>1) goto JUMP;						
					}
					largest_primeFactor=i;
					Console.WriteLine(largest_primeFactor);
					mult_Value *= i;
					if(mult_Value == target) break;
			JUMP:	count=0;
				}
			}
			Console.Write("So the answer is " + largest_primeFactor);
		}
	}
}