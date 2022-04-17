int N = 10;
int a = 1;

while (a < N + 1)
{
    if (a % 2 == 0)
    {
        Console.Write(a);
        Console.Write(", ");
    }
    a++;
}
Console.WriteLine ("расчёт окончен");