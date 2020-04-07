<Query Kind="Program" />

/* 215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
What is the sum of the digits of the number 21000? */

namespace Solve
{
	class Q16
	{
		static void Main(string[] args)
		{
			int[] answer = new int[1];
			int ansplus = 0;
			int temp = 0;
			int templength = 0;
			int powern = 1000;
			
			answer[0] = 2;
			
			for(int it=1; it<powern; it++)
			{
				for(int i=answer.Length-1; i>=0; i--)
				{
					temp = answer[answer.Length-(i+1)];
					templength = answer.Length;
					if(i==0 && temp>=5)
					{
						Array.Resize<int>(ref answer, answer.Length+1);				
					}
					temp *= 2;
					if(temp>=10 && templength==answer.Length)
					{
						if(ansplus!=0)
						{
							temp+=ansplus;
							ansplus=0;
						}					
						ansplus += 1;
						answer[templength-(i+1)] = temp-10;
					}
					else if(temp>=10 && templength!=answer.Length)
					{						
						answer[answer.Length-1] += 1;
						if(ansplus!=0) 
						{
							temp+=ansplus;
							ansplus=0;
						}
						answer[answer.Length-2] = temp-10;
					}
					else
					{
						if(ansplus!=0) 
						{
							temp+=ansplus;
							ansplus = 0;
						}
						answer[templength-(i+1)] = temp;
					}
				}
			}
			
			Console.Write("Full number = ");
			for(int i=answer.Length-1; i>=0; i--)
			{
				Console.Write(answer[i]);
			}
			Console.Write("\n" + "Sum of digits = ");
			int finalanswer = 0;
			for(int i=answer.Length-1; i>=0; i--)
			{
				finalanswer += answer[i];
			}
			Console.Write(finalanswer);
			
		}
	}
}