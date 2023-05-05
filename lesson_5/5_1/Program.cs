// Задача 1: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

void Print(int[] arr)//функция выводит массив (количество элементов в массиве)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
int[] EightMass(int size, int from, int to)  //функция заполняет массив(начало деапозона и конец диапозона)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);//чтобы 10 тоже вошла в массив
    return arr;
}
void ChangeValue(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)    
        arr[i] = -arr[i];    
}



int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);


int[] mass = EightMass(num, start, stop);
Print(mass);

ChangeValue(mass); //выводит массив

Print(mass);











//Задача 2: Задайте массив. Напишите программу, которая 
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да