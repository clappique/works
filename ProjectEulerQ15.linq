<Query Kind="Program" />

static void Main(string[] args)
{
	int nref = 0;
	int[] narray = new int[1];
	int ord = 0;
	for(int i=1; i<=40; i++)
	{		
		for(int j=1; j<=i; j++)
		{
			if(i%j==0) nref++;
		}
		if(nref==2)
		{
			Array.Resize<int>(ref narray, narray.Length+1);
			narray[ord]=i;
			ord++;
		}
		nref=0;		
	}
	Array.Resize<int>(ref narray, narray.Length-1);
	int[] divisorarr = new int[20];
	for(int i=1; i<=20; i++) divisorarr[i-1]=i;
	while(true)
	{
		ord=0;
		for(int i=0; i<=19; i++)
		{			
			for(int j=0; j<=narray.Length-1; j++)
			{
				if(divisorarr[i] % narray[j]==0 && divisorarr[i]!=1 && narray[j]!=1 && divisorarr[i]!=narray[j])
				{
					Array.Resize<int>(ref divisorarr, divisorarr.Length+1);
					divisorarr[i]=divisorarr[i]/narray[j];
					divisorarr[divisorarr.Length-1]=narray[j];
					ord++;
				}
			}
		}
		if(ord==0) break;
	}
	int[] dividendarr = new int[20];
	for(int i=21; i<=40; i++) dividendarr[i-21]=i;
	while(true)
	{
		ord=0;
		for(int i=0; i<=19; i++)
		{			
			for(int j=0; j<=narray.Length-1; j++)
			{
				if(dividendarr[i] % narray[j]==0 && dividendarr[i]!=1 && narray[j]!=1 && dividendarr[i]!=narray[j])
				{
					Array.Resize<int>(ref dividendarr, dividendarr.Length+1);
					dividendarr[i]=dividendarr[i]/narray[j];
					dividendarr[dividendarr.Length-1]=narray[j];
					ord++;
				}
			}
		}
		if(ord==0) break;
	}
	while(true)
	{
		ord=0;		
		for(int i=0; i<=dividendarr.Length-1; i++)
		{
			for(int j=0; j<=divisorarr.Length-1; j++)
			{
				if(dividendarr[i]==divisorarr[j] && dividendarr[i]!=1)
				{
					dividendarr[i]=1;
					divisorarr[j]=1;
					ord++;					
				}
			}
		}		
		if(ord==0) break;
	}
	int divisor=1;
	for(int i=0; i<=divisorarr.Length-1; i++)
	{
		divisor *= divisorarr[i];
	}	
	decimal answer=1;
	for(int i=0; i<=dividendarr.Length-1; i++)
	{
		answer *= dividendarr[i];		
	}
	answer = answer/divisor;
	Console.Write(answer);
}