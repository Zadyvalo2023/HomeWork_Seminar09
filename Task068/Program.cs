﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
 class Program
{
    static int Ackermann(int m, int n)//Эта строка объявляет статический метод Ackermann с двумя целочисленными параметрами m и n, который будет вычислять функцию Аккермана. 
    {
        if (m == 0)//Эта строка начинает условное выражение, проверяющее, равно ли значение m нулю.
        {
            return n + 1;//Если значение m равно 0, то возвращается значение n + 1. 
        }
        else if (m > 0 && n == 0)// Если условие в строке 4 не выполняется, то проверяется это условие - m больше 0 и n равно 0. 
        {
            return Ackermann(m - 1, 1);
        }
        else// Если ни одно из предыдущих условий не выполняется, то выполняется эта часть кода. 
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));//В этой строке рекурсивно вызывается функция Ackermann с аргументами m - 1 и результатом вызова функции Ackermann с аргументами m и n - 1. 
        }
    }
     static void Main(string[] args)
    {
        int m = 2;
        int n = 3;
        int result = Ackermann(m, n);// Эта строка вызывает функцию Ackermann с аргументами m и n и сохраняет ее результат в переменную result. 
        Console.WriteLine($"A({m}, {n}) = {result}");
         m = 3;
        n = 2;
        result = Ackermann(m, n);//Эта строка вызывает функцию Ackermann с новыми значениями m и n и сохраняет ее результат в переменную result. 
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
}