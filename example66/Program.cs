// Example 66 
Console.Clear();
void Sum(int m, int n)
{
    Console.Write(Result(m - 1, n));
}
int Result(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Result(m, n);
        return res;
    }
}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Sum(m, n);
