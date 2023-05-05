// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.


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

string IfInNum(int[] arr, int num)//функция определяет есть нужное  число в массиве или нет.
{
    for (int i = 0; i < arr.Length; i++)
   {
        if (num == arr[i])        
            return "Yes";        
   }
    return "No";
}

Console.Write("Количество элементов: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапазона: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапазона: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Console.Write("Введите число: ");
Console.WriteLine(IfInNum(mass, int.Parse(Console.ReadLine())));

