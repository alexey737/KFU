int Fibo(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;
    return Fibo(n - 1) + Fibo(n - 2);
}
Console.WriteLine(Fibo(10));
int Fibo2(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;
    int fst = 0;
    int snd = 1;
    int cur = 0;
    for (int i = 2; i<=n; i++)
    {
        cur = fst + snd;
        fst = snd;
        snd = cur;
    }
    return cur;
}
Console.WriteLine(Fibo2(10));