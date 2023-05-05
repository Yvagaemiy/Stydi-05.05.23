// Задача 2: Напишите программу, которая принимает
//на вход три числа и выдаёт максимальное из этих
//чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Введите первое число");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int n2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int n3 = int.Parse(Console.ReadLine()!);
int max = n1;
if (max < n2) max = n2;
if (max < n3) max = n3;

Console.WriteLine("Максимальное из этих чисел = " + max);