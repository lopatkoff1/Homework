 //Задача 2: Напишите программу, которая выводит третью цифру
 // заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//326792 -> 6

int IntputInt(string msg)
{
    Console.WriteLine(msg + " > ");
    string inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
int numIn = IntputInt("Введите число");
if(numIn / 100 == 0)
{
    Console.WriteLine("Третей цифры нет");
}
else
{
    while(numIn > 1000)
    {
        numIn = numIn / 10;
    }
    Console.WriteLine($"Третья цифра:{numIn % 10}");
}