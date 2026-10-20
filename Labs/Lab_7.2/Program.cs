void Task1()
{
    string s = Console.ReadLine();
    int n = int.Parse(Console.ReadLine());
    if (n >= 0 && n <= s.Length-1)
        Console.Write(s.Remove(n, 1));
    else
        Console.WriteLine("в строке нет такого индекса");
}
void Task2()
{
    string s = Console.ReadLine();
    Console.Write(s.Replace(" ", ""));
}

void Task3()
{
    string s = Console.ReadLine();
    s = s.ToLower();
    int ans = 0;
    string a = "аеёиоуыэюя";
    for (int i=0;i<s.Length;i++)
        if (a.Contains(s[i]))
            ans++;
    Console.Write(ans);
}
