// Задача 1: Задайте массив из 12 элементов, заполненный 
//случайными числами из промежутка [-9, 9]. Найдите сумму 
//отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
//положительных чисел равна 29, сумма отрицательных равна 
//-20.

void Print(int[] arr)//функция выводит массив
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
int[] EightMass(int size, int from, int to)  //функция заполняет массив
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);//чтобы 10 тоже вошла в массив
    return arr;
}
void SumPosNeg (int[] arr)
{
    int Pos;
    int Neg;
    Pos=0;
    Neg=0;

    for (int i = 0; i < arr.Length; i++ )
    {
        if (arr [i] >= 0)
           Pos += arr [i];

        else
        
           Neg += arr [i]; 
    }
      Console.WriteLine($"pos: {Pos} , neg: {Neg}");
}




int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num, start, stop);
Print(mass);

 SumPosNeg(mass);
