class Balance
{
    private int sum;
    public void Add(int x)
    {
        sum += x;
    }
    public void Sub(int x)
    {
        if (sum - x >= 0)
            sum = sum - x;
        else
            Console.Write("Недостаточно средств");
    }
}

