﻿// Задача 3: Напишите программу, которая принимает на 
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27. 
//5 -> 1, 8, 27, 64, 125
//3 -> 1, 8, 27 
//5 -> 1, 8, 27, 64, 125


int n = int.Parse(Console.ReadLine()!) ;


int k = int.Parse(Console.ReadLine()!) ;

for (int i=1;i<=n;i++)
{
    Console.WriteLine(k= i*i*i);
}
