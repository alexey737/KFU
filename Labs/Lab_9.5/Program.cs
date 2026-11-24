//TASK 7
int number = 0;
bool isCorrect = false;

while(!isCorrect)
{
    Console.Write("Введите целое число: ");
    string input = Console.ReadLine();
    try
    {
        number = int.Parse(input);
        isCorrect = true;
    }
    catch(FormatException)
    {
        Console.WriteLine("Ошибка, это не число, попробуйте еще раз");
    }
}
Console.Write($"Супер, вы ввели число {number}");
