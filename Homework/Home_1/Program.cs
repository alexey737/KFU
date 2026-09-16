Console.Write("Введите строку: ");
string s = Console.ReadLine().ToLower();

Console.Write("Введите символ который нужно найти: ");
char a = Console.ReadKey().KeyChar;
Console.WriteLine();
char a1 = char.ToLower(a);

int count = 0;
for (int i = 0; i<s.Length; i++)
{
	if (s[i]==a1)
	{
		count++;
	}
}
Console.Write($"В строке символ {a} встречается {count} раз(а)");
