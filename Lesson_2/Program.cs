﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int start,int end)
{
    //Базовый метод
    if(start==end) return N;
    //Рекурсивный метод
    return(start+SumNumbers(start+1,end ));
}
Console.WriteLine($"Сумма чисел от {M} до {N} равна: {SumNumbers(M,N)}");