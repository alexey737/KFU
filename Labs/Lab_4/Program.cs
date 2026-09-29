void Task1()
{
	void SayHello()
	{	
		Console.Write("Привет, студент!");
	}
	SayHello();
	SayHello();
	SayHello();
}

void Task2()
{
	Console.WriteLine("Введите число которое нужно возвести в квадрат");
	int a = int.Parse(Console.ReadLine());
	int Square(int x)
	{
		int a = (int)Math.Pow(x,2);
		return a;
	}
	Console.Write(Square(a));
}

void Task3()
{
	Console.Write("Введите элементы массива через пробел");
	double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
	double Average(params double[] numbers)
	{
		double sum = 0;
		foreach(double x in numbers)
			sum+=x;
		double aver = sum/numbers.Length;
		return aver;
	}
	Console.Write(Average(array));
}

void Task4()
{
	Console.WriteLine("введите первое число");
	int a = int.Parse(Console.ReadLine());
	Console.WriteLine("введите второе число");
	int b = int.Parse(Console.ReadLine());
	Console.WriteLine("введите операцию");
	char x = Console.ReadKey().KeyChar;
	int Calculate(int x,int y, char s)
	{
		if (s == '+')
			return x+y;
		if (s == '-')
			return x-y;
		if (s == '*')
			return x*y;
		if (s == '/')
			return x/y;
		return 0;
	}
	Console.Write(Calculate(a,b,x));
}

void Task5()
{
	Console.Write("Введите элементы массива через пробел");
	int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
	void MiMa(out int mx,out int mi,params int[] numbers)
	{
		mx = numbers.Max();
		mi = numbers.Min();
	}
	MiMa(out int mx, out int mi, array);
	Console.Write($"{mx},{mi}");
}

Console.WriteLine("1 - 1 задание");
Console.WriteLine("2 - 2 задание");
Console.WriteLine("3 - 3 задание");
Console.WriteLine("4 - 4 задание");
Console.WriteLine("5 - 5 задание");
int c = int.Parse(Console.ReadLine());
switch(c)
{
	case 1:Task1();break;
	case 2:Task2();break;
	case 3:Task3();break;
	case 4:Task4();break;
	case 5:Task5();break;
	default: Console.Write("error");break;
}

	

		
