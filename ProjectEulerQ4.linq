<Query Kind="Program" />

/* A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers. */

namespace Solve
{
	class Q4
	{
		static void Main(string[] args)
		{
			int productNumber;
			int palindrome = 0;
			string productString;
			for(int i=100; i<1000; i++)
			{
				for(int j=100; j<1000; j++)
				{
					productNumber = i*j;
					productString = productNumber.ToString();
					int strLength = productString.Length;
					if(strLength%2==0)
					{
						int opt1result = 0;
						for(int k=1; k<=(strLength/2); k++)
						{
							if(productString[k-1]!=productString[strLength-k]) break;
							opt1result = k;
						}
						if(opt1result==(strLength/2) && productNumber>palindrome) palindrome = productNumber;
					}
					else
					{
						int opt2result = 0;
						for(int k=1; k<=((strLength-1)/2); k++)
						{
							if(productString[k-1]!=productString[strLength-k]) break;
							opt2result = k;
						}
						if(opt2result==((strLength-1)/2) && productNumber>palindrome) palindrome = productNumber;
					}
				}
			}
			Console.Write(palindrome);
		}
	}
}
						
					
	
