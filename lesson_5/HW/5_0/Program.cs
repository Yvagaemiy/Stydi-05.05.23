/*Задача 1: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в 
массиве.
[345, 897, 568, 234] -> 2
*/





void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)    
        Console.Write($"{arr[i]} ");
    
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)    
        arr[i] = new Random().Next(from, to + 1);
    
    return arr;
}

int EvenNum(int[] arr)  //функция считает четные в массиве и показывает их количество
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)        
            count += 1;                
    }
    return count;
}
int КолЭлементовМассива =10; //автомотическое заполнение
//int колЭлементовМассива = int.Parse(Console.ReadLine()!);

int Начало =0; //автомотическое заполнение
//int начало = int.Parse(Console.ReadLine()!);

int Конец =10; //автомотическое заполнение
//int конец = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(КолЭлементовМассива, Начало, Конец);
Print(mass);
Console.Write("Сумма четных в массиве: ");
Console.WriteLine(EvenNum(mass));
