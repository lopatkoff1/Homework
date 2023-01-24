// Задача 3: Напишите программу, которая принимает на вход цифру,
 // обозначающую день недели, и проверяет,
 //  является ли этот день выходным.
//6 -> да 
//7 -> да 
//1 -> нет

int IntputInt(string msg)
{
    Console.WriteLine(msg + " > ");
    string inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
int numberDay = IntputInt("Введите день недели");
if(numberDay == 6 || numberDay == 7)
{
    System.Console.WriteLine("Выходной");
}
else
{
    System.Console.WriteLine("Будний день");
}
