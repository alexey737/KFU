/*
Console.WriteLine("Введите день недели");
int a = int.Parse(Console.ReadLine());                                                         ОБЪЕДИНЕНИЕ ПРОГРАММ СНИЗУ

switch(a)
{
	case 1:Console.Write("ПН");break;
	case 2:Console.Write("ВТ");break;
	case 3:Console.Write("СР");break;
	case 4:Console.Write("ЧТ");break;
	case 5:Console.Write("ПТ");break;
	case 6:Console.Write("СБ");break;
	case 7:Console.Write("ВС");break;
	default:Console.Write("ошибка");break;
}

2 Задание
Console.WriteLine("Введите год");
int a = int.Parse(Console.ReadLine());
if ((a%400==0) || ((a%4==0) && !(a%100==0)))
{
	Console.Write("Високосный");
}
else
{
	Console.Write("Не високосный");
}

3 задание
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("1 - сложить");
Console.WriteLine("2 - вычесть");
Console.WriteLine("3 - умножить");
Console.WriteLine("4 - разделить") ; 
int c = int.Parse(Console.ReadLine());
switch(c)
{
	case 1:Console.Write(a+b);break;
	case 2:Console.Write(a-b);break;
	case 3:Console.Write(a*b);break;
	case 4:Console.Write(a/b);break;
	default:Console.Write("error");break;
}

4 задание
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("+ - сложить");
Console.WriteLine("- - вычесть");
Console.WriteLine("* - умножить");
Console.WriteLine("/ - разделить") ; 
string c = Console.ReadLine();
switch(c)
{
	case "+":Console.Write(a+b);break;
	case "-":Console.Write(a-b);break;
	case "*":Console.Write(a*b);break;
	case "/":
        if (b!=0)
        {
			Console.Write(a/b);break;
		}
		else
		{
			Console.Write("на 0 делить нельзя");break;
		}
	default:Console.Write("error");break;
}


//5 задание
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
if (a!=0)
{
	int D = (int)(4*Math.Pow(b,2)-a*c);
	if (D>0)
	{
		int x1 = (int)((-b+Math.Sqrt(D))/2*a);
		int x2 = (int)((-b-Math.Sqrt(D))/2*a);
		Console.Write($"{x1}, {x2}");
	}
	else if (D<0)
	{
		Console.Write("корней нет");
	}
	else
	{
		int x = (int)((-b+Math.Sqrt(D))/2*a);
		Console.Write($"{x}");
	}
}
else
{
	Console.Write("не квадратное уравнение");
}
*/
//ОБЪЕДИНЕНИЕ В ОДНУ ПРОГРАММУ
Console.WriteLine("1-решить первое задание");
Console.WriteLine("2-решить второе задание");
Console.WriteLine("3-решить третье задание");
Console.WriteLine("4-решить четвертое задание");
Console.WriteLine("5-решить четвертое задание");
int d = int.Parse(Console.ReadLine());
	switch(d)
	{
		case 1: fsttask();break;
		case 2: sndtask();break;
		case 3: thdtask();break;
		case 4: fthtask();break;
		case 5: fifthtask();break;
		default: Console.Write("error");break;
	}
static void fsttask()
{
	Console.WriteLine("Введите день недели");
	int a = int.Parse(Console.ReadLine());

	switch(a)
	{
		case 1:Console.Write("ПН");break;
		case 2:Console.Write("ВТ");break;
		case 3:Console.Write("СР");break;
		case 4:Console.Write("ЧТ");break;
		case 5:Console.Write("ПТ");break;
		case 6:Console.Write("СБ");break;
		case 7:Console.Write("ВС");break;
		default:Console.Write("ошибка");break;
	}
}
static void sndtask()
{
	Console.WriteLine("Введите год");
	int a = int.Parse(Console.ReadLine());
	if ((a%400==0) || ((a%4==0) && !(a%100==0)))
	{
		Console.Write("Високосный");
	}
	else
	{
		Console.Write("Не високосный");
	}
}
static void thdtask()
{
	Console.WriteLine("Введите первое число");
	int a = int.Parse(Console.ReadLine());
	Console.WriteLine("Введите второе число");
	int b = int.Parse(Console.ReadLine());
	Console.WriteLine("1 - сложить");
	Console.WriteLine("2 - вычесть");
	Console.WriteLine("3 - умножить");
	Console.WriteLine("4 - разделить") ; 
	int c = int.Parse(Console.ReadLine());
	switch(c)
	{
		case 1:Console.Write(a+b);break;
		case 2:Console.Write(a-b);break;
		case 3:Console.Write(a*b);break;
		case 4:Console.Write(a/b);break;
		default:Console.Write("error");break;
	}
}
static void fthtask()
{
	Console.WriteLine("Введите первое число");
	int a = int.Parse(Console.ReadLine());
	Console.WriteLine("Введите второе число");
	int b = int.Parse(Console.ReadLine());
	Console.WriteLine("+ - сложить");
	Console.WriteLine("- - вычесть");
	Console.WriteLine("* - умножить");
	Console.WriteLine("/ - разделить") ; 
	string c = Console.ReadLine();
	switch(c)
	{
		case "+":Console.Write(a+b);break;
		case "-":Console.Write(a-b);break;
		case "*":Console.Write(a*b);break;
		case "/":
			if (b!=0)
			{
				Console.Write(a/b);break;
			}
			else
			{
				Console.Write("на 0 делить нельзя");break;
			}
		default:Console.Write("error");break;
	}
}
static void fifthtask()
{
	Console.WriteLine("Введите первое число");
	int a = int.Parse(Console.ReadLine());
	Console.WriteLine("Введите второе число");
	int b = int.Parse(Console.ReadLine());
	Console.WriteLine("Введите третье число");
	int c = int.Parse(Console.ReadLine());

	if (a!=0)
	{
		int D = (int)(4*Math.Pow(b,2)-a*c);
		if (D>0)
		{
			int x1 = (int)((-b+Math.Sqrt(D))/2*a);
			int x2 = (int)((-b-Math.Sqrt(D))/2*a);
			Console.Write($"{x1}, {x2}");
		}
		else if (D<0)
		{
			Console.Write("корней нет");
		}
		else
		{
			int x = (int)((-b+Math.Sqrt(D))/2*a);
			Console.Write($"{x}");
		}
	}
	else
	{
		Console.Write("не квадратное уравнение");
	}
}
