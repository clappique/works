<Query Kind="Program" />

/* 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20? */

namespace Solve
{
	class Q5
	{
		static void Main(string[] args)
		{
			int i=1;
			int escapeRef = 0;
			int answer=0;
			bool stayCal = true;
			while(stayCal)
			{
				for(int j=i; j<=i; j++)
				{
					for(int k=1; k<=20; k++)
					{
						if(j%k==0) escapeRef+=1;
					}
					if(escapeRef==20) 
					{
						stayCal=false;
						answer = j;
					}
					escapeRef=0;
				}
				i++;
			}
			Console.Write(answer);
		}
	}
}			