using System.Diagnostics.CodeAnalysis;

void Task1()
{
    int n = int.Parse(Console.ReadLine());
    if (n > 48)
        Console.WriteLine(Math.Abs(n - 48) * 3);
    else
        Console.WriteLine(Math.Abs(n - 48));
}
void Task2()
{
    string n = Console.ReadLine();
    int sum = 0;
    int proiz = 1;
    for (int i = 0; i<n.Length;i++)
    {
        sum += int.Parse(n[i].ToString());
        proiz *= int.Parse(n[i].ToString());
    }
    Console.Write($"произведение: {proiz}, сумма:  {sum}");
}
void Task3()
{
    int n = int.Parse(Console.ReadLine());
    if (n % 5 == 0 && n % 3 == 0)
        Console.Write("True");
    else
        Console.Write("False");
}
Task1();
Task2();
Task3();