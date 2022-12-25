int rec(int a, int b)
{
    if (a == b)
        return b;
    return a + rec(a + 1, b);
}
Console.Clear();
Console.Write("Напишите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите число 2: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));
