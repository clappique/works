<Query Kind="Program" />

/* If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used? 


NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
*/

static void Main(string[] args)
{
	string[] numbersArr = new string[1000];
	for(int i=1; i<=1000; i++)
	{
		numbersArr[i-1]=i.ToString();					
	}
	for(int i=1; i<=9; i++)
	{
		if(numbersArr[i-1]=="1" || numbersArr[i-1]=="2" || numbersArr[i-1]=="6")
		{	
			numbersArr[i-1]="3";
		}
		else if(numbersArr[i-1]=="4" || numbersArr[i-1]=="5" || numbersArr[i-1]=="9")
		{
			numbersArr[i-1]="4";
		}
		else
		{
			numbersArr[i-1]="5";
		}	
	}
	for(int i=10; i<=99; i++)
	{
		if(numbersArr[i-1][0]=='1' && numbersArr[i-1]!="10")
		{
			if(numbersArr[i-1]=="11" || numbersArr[i-1]=="12")
			{
				numbersArr[i-1]="6";
			}
			else if(numbersArr[i-1]=="15" || numbersArr[i-1]=="16")
			{
				numbersArr[i-1]="7";
			}
			else if(numbersArr[i-1]=="17")
			{
				numbersArr[i-1]="9";
			}			
			else
			{
				if(numbersArr[i-1]!="10")
				{
					numbersArr[i-1]="8";
				}
			}
		}
		else if(numbersArr[i-1][1]=='0')
		{
			if(numbersArr[i-1][0]=='1')
			{
				numbersArr[i-1]="3";
			}
			else if(numbersArr[i-1][0]=='4' || numbersArr[i-1][0]=='5' || numbersArr[i-1][0]=='6')
			{
				numbersArr[i-1]="5";
			}
			else if(numbersArr[i-1][0]=='7')
			{
				numbersArr[i-1]="7";
			}
			else
			{
				numbersArr[i-1]="6";
			}
		}
	}
	
	double j=0;
	double k=0;
	int jint=0;
	int kint=0;
	
	for(int i=10; i<=99; i++)
	{
		if(numbersArr[i-1].Length==2)
		{			
			j = (Char.GetNumericValue(numbersArr[i-1][0]) * 10)-1;
			k = Char.GetNumericValue(numbersArr[i-1][1])-1;
			jint = Convert.ToInt32(j);
			kint = Convert.ToInt32(k);
			numbersArr[i-1] = (Int32.Parse(numbersArr[jint]) + Int32.Parse(numbersArr[kint])).ToString();			
		}		
	}
		
	for(int i=100; i<=999; i++)
	{	
		if(numbersArr[i-1][1] == '0' && numbersArr[i-1][2] == '0')
		{
			j = Char.GetNumericValue(numbersArr[i-1][0])-1;
			jint = Convert.ToInt32(j);			
			numbersArr[i-1] = (Int32.Parse(numbersArr[jint]) + 7).ToString();   /* plus 7 for 'hundred' */
		}
	}
	
	string tempstr;
	
	for(int i=100; i<=999; i++)
	{		
		if(numbersArr[i-1].Length == 3)
		{
			j = (Char.GetNumericValue(numbersArr[i-1][0])*100)-1;
			jint = Convert.ToInt32(j);
			tempstr = numbersArr[i-1];    /* hold the original value before it changes */
			numbersArr[i-1] = (Int32.Parse(numbersArr[jint]) + 3).ToString();    /* plus 3 for 'and' */			
			jint = Int32.Parse(tempstr.Substring(1))-1;		
			numbersArr[i-1] = (Int32.Parse(numbersArr[i-1]) + Int32.Parse(numbersArr[jint])).ToString();
		}
	}

	numbersArr[999] = "11";
	
	int answer = 0;
	for(int i=1; i<=1000; i++)
	{
		answer += Int32.Parse(numbersArr[i-1]);
	}			
	
	Console.Write(answer);
}

	
	/*
	1 one   3
	2 two   3
	3 three   5
	4 four   4
	5 five   4
	6 six   3
	7 seven   5
	8 eight   5
	9 nine   4
	
	  10 ten    3
	11 eleven     6 
	12 twelve     6
	13 thirteen     8
	14 fourteen     8
	15 fifteen      7
	16 sixteen      7
	17 seventeen    9
	18 eighteen     8
	19 nineteen     8
	  20 twenty       6
	21 twenty-one      6 + 3
	...
	  30 thirty        6
	...
	  40 forty          5
	... 
	  50 fifty           5
	...
	  60 sixty          5
	...
	  70 seventy        7
	...
	  80 eighty         6
	...
	  90 ninety          6
	...
	  99 ninetynine      6 + 4    
	100 one hundred         3 + 7
	101 one hundred and one       3 + 7 + 3 + 3
	102 one hundred and two...    3 + 7 + 3 + 3
	*/