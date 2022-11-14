Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int b = 1;

while (b <= n)
{
    if (b % 2 == 0)
    Console.WriteLine($"четное число {b}");
    b++;

}

