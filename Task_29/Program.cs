﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// задаёт массив из 8 элементов
// выводит их на экран

void FillArrey(int[] arrey)
{
    int lgth = arrey.Length;
    int i = 0;
    while (i < lgth)
    {
        arrey[i] = new Random().Next(-100, 100);
        i = i+1;
    }
}

void PrintArrey (int[] arr)
{
    int cnt = 0;
    int length = arr.Length;
    while (cnt < length)
    {
        Console.Write ($"{arr[cnt]}, ");
        cnt = cnt +1;
    }
}
int[] numbers = new int[8];
FillArrey (numbers);
PrintArrey (numbers);