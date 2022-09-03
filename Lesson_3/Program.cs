// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int Ackerman(int M,int N)
{
    //Базовый случай
    if (M==0) return N+1;
    else if (N == 0) return Ackerman(M - 1, 1);
    //Рекурсивный случай 
    return(Ackerman(M-1,Ackerman(M,N-1)));
}
Console.WriteLine($"Функция Аккермана равна: {Ackerman(M,N)}");