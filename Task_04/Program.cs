int i = 1;
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
    if (i % 2 != 1)
    {
        Console.Write(i + "");
        
    }
    i++;
}


   

