<Query Kind="Program" />

/* Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum. */

namespace Solve
{
	class Q6
	{
		static void Main(string[] args)
		{
			double sumOftheSq = 0;
			double bareSum = 0;
			double answer;
			for(int i=1; i<=100; i++)
			{
				double j = Math.Pow(i, 2);
				sumOftheSq += j;
				bareSum += i;
			}
			answer = Math.Abs(sumOftheSq-(Math.Pow(bareSum, 2)));
			Console.Write(answer);
		}
	}
}			