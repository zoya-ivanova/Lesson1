Console.WriteLine("Введите первое число 1 : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число 2 : ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Первое число больше,второе меньше");
}
else
{
    Console.WriteLine("Первое число меньше,второе больше");
}