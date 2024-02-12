﻿// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
Console.Write("Введите начальное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

void ShowNumber (int start, int end)
{
    if(start==end)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumber(start+1,end);
}
ShowNumber(N,M);