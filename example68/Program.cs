//Wxmple 68
Console.Clear();
void Result(int m, int n)
{
    Console.Write(func(m, n)); 
}

int func(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return func(m - 1, 1);
    }
    else
    {
        return (func(m - 1, func(m, n - 1)));
    }
}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Result(m,n);
