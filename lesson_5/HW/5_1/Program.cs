//Задача 2: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 67] -> 0

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

int SumNegNum(int[] arr)  //Функция выполняет сумму элементов, стоящих на нечётных позициях.
{
    int count = 0;

    for (int i = 0; i < arr.Length; i+=2)
    
        count +=arr[i];        
    
    return count;
}


int КолЭлементовМассива =7; 

int Начало =0; 

int Конец =7; 

int[] mass = MassNums(КолЭлементовМассива, Начало, Конец);
Print(mass);
Console.Write("сумму элементов, стоящих на нечётных позициях: ");
Console.WriteLine( SumNegNum (mass));

