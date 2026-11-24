//TASK 8
using System.Linq.Expressions;

void CheckAge(int age)
{
    if (age<0)
        throw new ArgumentOutOfRangeException(nameof(age), "Возраст не может быть отрицательным");
    Console.Write("age is correct");
}


//TASK 9
void TransferMoney(decimal balance, decimal amount)
{
    if (amount<=0)
        throw new ArgumentException(nameof(amount), "Нельзя перевести отрицательную сумму и ничего");
    if (amount > balance)
        throw new InvalidOperationException("На вашем балансе недостаточно средств");
    Console.Write("деньги доставлены");
    balance-=amount;
}


// TASK 10
void InnerMethod()
{
    try
    {
        int result = 10 / int.Parse("0");
    }
    catch(Exception ex)
    {
        Console.WriteLine("Внутр кэтч, произошла ошибка : " + ex.Message);
        throw;
    }
}
try
{
    InnerMethod();
}
catch(Exception ex)
{
    Console.WriteLine("Я поймал ошибку");
    Console.WriteLine("сообщение " + ex.Message);
    Console.WriteLine("type of error " + ex.GetType().Name);

}