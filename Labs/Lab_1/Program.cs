# 1 программа
int a = 20;
int b = 10;
Console.Write(a+b);

# 2 программа
string a = Console.ReadLine();
int a1 = int.Parse(a);
string b = Console.ReadLine();
int b1 = int.Parse(b);
Console.Write(a1+b1);

# 3 программа
Console.WriteLine("Укажите свой возраст");
int age = int.Parse(Console.ReadLine());
bool tage = age >= 18;
Console.WriteLine(tage);

# 4 программа
Console.Write("Угадай число");
int a = int.Parse(Console.ReadLine());
if (a==7)
{
Console.Write("Угадал");
}
else
{
Console.Write("Не угадал");
}
	
# 5 программа
Console.Write("Угадай число");
int a = int.Parse(Console.ReadLine());
if (a>7)
{
Console.Write("Мое число меньше");
}
else if (a<7)
{
Console.Write("Мое число больше");
}
else
{
Console.Write("Угадал");
}
