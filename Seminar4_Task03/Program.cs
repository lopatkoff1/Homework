//Напишите программу, которая задаёт массив из 8
 //элементов и выводит их на экран.
//1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
// -> 8


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int lenArray = ReadInt("Введите длинну массива: ");

int[] Array = new int[lenArray];
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1,9);
    Console.Write(Array[i] + " ");
}



