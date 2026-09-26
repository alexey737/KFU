Console.WriteLine("1 - 1 задание");
Console.WriteLine("2 - 2 задание");
Console.WriteLine("3 - 3 задание");
Console.WriteLine("4 - 4 задание");
string s = Console.ReadLine();
if (int.TryParse(s, out int a))
{
	switch(a)
	{
		case 1: Task1();break;
		case 2: Task2();break;
		case 3: Task3();break;
		case 4: Task4();break;
		default: Console.Write("нет такого задания");break;
	}
}
else
	Console.Write("error");









static void Task1()
{
	Console.WriteLine("Введите числа для массива через пробел");
	string s = Console.ReadLine();
	int[] arr = s.Split(' ').Select(int.Parse).ToArray();

	Console.WriteLine("Введите число которое нужно найти или вставить");
	string c = Console.ReadLine();
	bool inout = false;
	if (int.TryParse(c, out int num))
	{
		for (int i=0;i<arr.Length;i++)
		{
			if (num==arr[i])
			{
				Console.Write($"В строке есть это число с индексом {i}");
				inout = true;
				break;
			}
			if (arr[i]>num)
			{
				Console.Write($"В строке нет этого числа,он должен стоять на индексе {i}");
				inout=true;
				break;
			}
		}
		if (!inout)
			Console.Write($"Его нет в строке,его место на {arr.Length} индексе");
	}

	else
		Console.Write("error");
}

static void Task2()
{
	Console.WriteLine("Введите первое число");
	string s = Console.ReadLine();
	Console.WriteLine("Введите второе число");
	string c = Console.ReadLine();
	if (int.TryParse(s,out int a) && int.TryParse(c,out int b))
	{
		if (a>b)
		{
			while (b!=0)
			{
				int q = a;
				a = b;
				b = q%b;
			}
			Console.Write(a);
		}
		else
		{
			while (a!=0)
			{
				int q = b;
				b = a;
				a = q%a;
			}
			Console.Write(b);
		}
	}
	else
		Console.Write("error");
}

static void Task3()
{
	Console.Write("Введите число для проверки");
	string s = Console.ReadLine();
	int sum=1;
	if (int.TryParse(s, out int num) && num > 2)
	{
		for (int i=2;i<num/2+1;i++)
		{
			if(num%i==0)
				sum+=i;
		}
		if (sum==num)
			Console.Write("Число совершенное");
		else
			Console.Write("Число несовершенное");
	}
	else
		Console.Write("error");
}

static void Task4()
{
	Console.WriteLine("Введи число для умножения");
	string s = Console.ReadLine();
	Console.WriteLine("Введи предел");
	string c = Console.ReadLine();
	if (int.TryParse(s,out int a) && int.TryParse(c,out int b))
	{
		for (int i =1;i<=b;i++)
			Console.WriteLine($"{a}*{i}={a*i}");
	}
	else
		Console.Write("error");
}