// TASK 4
List<string> names = new List<string>();
while (true)
{
    Console.Write("Выедите имя или stop: ");
    string input = Console.ReadLine();
    if (input.ToLower() == "stop")
    {
        break;
    }
    names.Add(input);
}
Console.WriteLine("\nВведенные имена");
foreach(string name in names)
{
    Console.WriteLine(name);
}