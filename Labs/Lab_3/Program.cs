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



int[] numbers = {1,2,3,4,5};
(numbers[0],numbers[4])=(numbers[4],numbers[0]);
(numbers[1],numbers[3])=(numbers[3],numbers[1]);
foreach (int x in numbers)
{
	Console.Write(x + " ");
}


int[] nums = {14, 6, 84, 35, 40, 4};
for (int i=0; i<nums.Length - 1;i++)
{
	for (int j=0; j<nums.Length - 1;j++)
	{
		if(nums[j]>nums[j+1])
		{
			(nums[j],nums[j+1])=(nums[j+1],nums[j]);
		}
	}
}
foreach (int x in nums)
{
	Console.Write(x+" ");
}
*/

int[,] matrix = {
	{3,6,2},
	{4,10,35},
	{12,35,89}
};
int sum = 0;
for (int i=0;i<matrix.GetLength(0);i++)
{
	for(int j = 0;j<matrix.GetLength(1);j++)
	{
		if (i==j)
		{
			Console.Write(matrix[i,j]+" ");
			sum+=matrix[i,j];
		}
	}
}
Console.Write("="+sum);
		