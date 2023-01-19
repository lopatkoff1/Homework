Console.WriteLine("Введите первое число: ");
int num_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_b = Convert.ToInt32(Console.ReadLine());

if (num_a > num_b)
{
    Console.WriteLine("Первое число " + num_a + " больше чем второе " + num_b);
}
else
{
    Console.WriteLine("Второе число " + num_b + " больше чем первое " + num_a);
}
