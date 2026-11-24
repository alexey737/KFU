//TASK 6
try
{
    Console.Write("Введите первое число: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = int.Parse(Console.ReadLine());

    int result = a / b;
    Console.WriteLine("result: " + result);
}

catch(FormatException)
{
    Console.WriteLine("Вы ввели не число");
}
catch(DivideByZeroException)
{
    Console.WriteLine("Делить на ноль нельзя");
}
finally
{
    Console.Write("Program finished");
}
