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
*/



int[] arr = new int[10];
for (int i=0;i<10;i++)
{
	Console.Write("Введите число");
	arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("1 - вывести массив");
Console.WriteLine("2 - найти мин макс и сумму");
Console.WriteLine("3 - перевернуть массив");
Console.WriteLine("4 - отсортировать пузырьком");
Console.WriteLine("5 - сделать все");
int a = int.Parse(Console.ReadLine());
switch(a)
{
	case 1: Task1();break;
	case 2: Task2();break;
	case 3: Task3();break;
	case 4: Task4();break;
	case 5: Task5();break;
	default: Console.Write("out of number");break;
}


void Task1()
{
foreach (int x in arr)
{
	Console.Write(x + " ");
}
}

void Task2()
{
int mi = 10000;
int mx = -10000;
int sum = 0;
foreach(int x in arr)
{
	if(x<mi)
		mi=x;
	if(x>mx)
		mx=x;
	sum+=x;
}
Console.Write($"max={mx},min={mi},sum={sum}");
}

void Task3()
{
Array.Reverse(arr);
foreach (int x in arr)
{
	Console.Write(x+" ");
}
}

void Task4()
{
for (int i=0; i<arr.Length - 1;i++)
{
	for (int j=0; j<arr.Length - 1;j++)
	{
		if(arr[j]>arr[j+1])
		{
			(arr[j],arr[j+1])=(arr[j+1],arr[j]);
		}
	}
}
foreach (int x in arr)
{
	Console.Write(x+" ");
}	
}	

void Task5()
{
Task1();
Task2();
Task3();
Task4();
}	
	