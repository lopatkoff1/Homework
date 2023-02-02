﻿// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами
//  массива.
// [3 7 22 2 78] -> 76


int size = 8;
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
     if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");



void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
