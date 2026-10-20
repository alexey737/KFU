string ToBinary(int x)
{
    if (x == 0)
        return "0";
    string res = "";
    while (x>0)
    {
        int ostatok = x % 2;
        res = ostatok + res;
        x = x / 2;
    }
    return res;
}
Console.Write(ToBinary(12));