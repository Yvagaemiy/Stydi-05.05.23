﻿//Задача 1: Напишите программу, которая принимает 
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int number = GetUserNumber();
int digits = CountNumbers(number);
Console.WriteLine(digits);

int GetUserNumber()
{
     int number = 0;
     while (number == 0 )
    {
       Console.WriteLine("введи число:  ");
       number = int.Parse(Console.ReadLine()!);

    }
        return number;

}
int CountNumbers(int n)
{
     int count = 0;
     while ( n > 0 )
     {
        n = n / 10;
        count++;

     }

     return count;

}