/*
for(int i = 1; i<=10;i++)
{
	for(int j = 1; j<=10; j++)
	{
		Console.WriteLine($"{i}*{j}={i*j}");
		if (j==10)
		{
			Console.WriteLine();
		}
	}
}


Console.WriteLine("Введите число");
string s = Console.ReadLine();
int sum = 0;
if (int.TryParse(s, out int N))
{
	for(int i=1;i<=N;i++)
	{
		sum+=i;
		if (i==N)
		{
			Console.Write(N);
		}
		else
		{
			Console.Write($"{i}+");
		}
	}
	Console.WriteLine();
	Console.Write(sum);
}
else
{
	Console.Write("error");
}



Console.WriteLine("Введите число");
string s = Console.ReadLine();
if (int.TryParse(s, out int N))
{
	for(int i = 1; i<=N; i++)
	{
		Console.WriteLine(new string('*',i));
	}
}
else
{
	Console.Write("error");
}	
*/

Console.WriteLine("Введите число");
string s = Console.ReadLine();
if (int.TryParse(s, out int N))
{
	bool Prost(int n)
	{
		if (n <= 1) return false;        

		for (int i = 2; i < n; i++)
		{
			if (n % i == 0)				
				return false;
		}
		return true;
	}
	if (Prost(N))
	{
		Console.Write("Число простое");
	}
	else
	{
		Console.Write("Не простое");
	}
}
else
{
	Console.Write("error");
}