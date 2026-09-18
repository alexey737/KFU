Console.WriteLine("1 - 1 задача");
Console.WriteLine("2 - 2 задача");
Console.WriteLine("3 - 3 задача");
Console.WriteLine("4 - 4 задача");
string text = Console.ReadLine();
if (int.TryParse(text, out int number))
{
	switch (number)
	{
		case 1: Task1();break;
		case 2: Task2();break;
		case 3: Task3();break;
		case 4: Task4();break;
		default: Console.Write("Ошибка");break;
	}
}
else
{
	Console.WriteLine("Ошибка ввода");
}

static void Task1()
{
Console.WriteLine("Введите число");
string text = Console.ReadLine();
if (int.TryParse(text, out int number))
{
	string s = number.ToString();
	char[] digits = s.ToCharArray();
	(digits[^2],digits[^1]) = (digits[^1],digits[^2]);
	s = new string(digits);
	int ans = int.Parse(s);
	Console.Write(s);
}
else
{
	Console.WriteLine("Ошибка ввода");
}
}

static void Task2()
{
Console.WriteLine("Введите число");
string text1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string text2 = Console.ReadLine();
if (int.TryParse(text1, out int num1) && int.TryParse(text2,out int num2))
{
	long sum = (long)num1+num2;
	if (sum>-2147483648 && sum<2147483647)
	{
		Console.Write("Подходит для int");
	}
	else
	{
		Console.Write("Не подходит для int");
	}
}
else
{
	Console.WriteLine("Ошибка ввода");
}
}

static void Task3()
{
Console.WriteLine("Введите число");
string text = Console.ReadLine();
if (int.TryParse(text, out int num))
{
	if (num==1 || num==12 || num==2)
	{
		Console.Write("Зима");
	}
	else if (num==3 || num==4 || num==5)
	{
		Console.Write("Весна");
	}
	else if (num==6 || num==7 || num==8)
	{
		Console.Write("Лето");
	}
	else if (num==9 || num==10 || num==11)
	{
		Console.Write("Осень");
	}
	else
	{
		Console.Write("Нет такого месяца");
	}
}
else
{
	Console.WriteLine("Ошибка ввода");
}
}

static void Task4()
{
Console.WriteLine("Введите число");
string text1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string text2 = Console.ReadLine();
Console.WriteLine("Введите третье число");
string text3 = Console.ReadLine();
if (int.TryParse(text1, out int a) && int.TryParse(text2,out int b) && int.TryParse(text3,out int c))
{
	if (a+b>c && a+c>b && c+b>a)
	{
		Console.Write("треугольник существует");
	}
	else
	{
		Console.Write("треугольник не существует");
	}
}
else
{
	Console.WriteLine("Ошибка ввода");
}
}