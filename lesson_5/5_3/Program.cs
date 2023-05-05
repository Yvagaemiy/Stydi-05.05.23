// 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

int InRange(int[] arr)// функция определяет в каком диапозоне лежит число
{   
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)        
            n += 1;          
    }
    return n;    
}


Console.Write("Количество элементов: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапазона: ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("Конец диапазона: ");
int stop = int.Parse(Console.ReadLine()!);



int[] mass = MassNums(num, start, stop);
Print(mass);
Console.Write("количество входящих: ");
Console.WriteLine(InRange(mass));
