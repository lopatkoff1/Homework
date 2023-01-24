// Задача 1: Напишите программу, которая принимает на вход 
 //трёхзначное число и на выходе показывает 
 //вторую цифру этого числа. Не использовать строки для расчета.
//456 -> 5
//782 -> 8
//918 -> 1

int Inputint(string msg)
{
    Console.WriteLine(msg + " > ");
    string inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
bool Validate(int number)
{
    if(number > 99 && number < 1000)
    {
        return true;
    }
    Console.WriteLine("Число не трёхзначное");
    return false;
}
int number = Inputint("Введите трёхзначное число");
if(Validate(number))
{
    int lastRank = ((number / 10) % 10);
    Console.WriteLine($"Вторая цифра числа {number} равна {lastRank}");
}