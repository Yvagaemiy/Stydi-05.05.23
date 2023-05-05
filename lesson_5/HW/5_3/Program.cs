// Задача 3: Задайте массив вещественных чисел. Найдите 
//разницу между максимальным и минимальным 
//элементов массива.
//[3, 7, 22, 2, 78] -> 76
//1
//1

//1
void Print(double[] arr)// меняется int на double.тем самым числа будут создоватся с запятой
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)    
        Console.Write($"{arr[i]} ");
    
    Console.WriteLine();
}
//2
double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)    
        arr[i] = Math.Round(n_new.NextDouble() * (to - from) + from, 2 ); //2 это два знака после запятой
    
    return arr;
}
//3
void DiffMaxMin(double[] arr)
{
    double n_max = arr[0];
    double n_min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (n_max < arr[i])        
            n_max = arr[i];
        
        else if (n_min > arr[i])        
            n_min = arr[i];        
    }

    Console.Write($"Max: {n_max}, Min: {n_min}. "); //консоль показывает минимум и максимум
    Console.WriteLine($"Difference: {n_max} - ({n_min}) = {Math.Round(n_max - n_min, 2)}");//это математическая формула вычета
    // из максимума минимум.2 не понятна
}

int КолЭлементовМассива =10; 

int Начало =0; 

int Конец =10; 

double[] mass = MassNums(КолЭлементовМассива, Начало, Конец);


Print(mass);

DiffMaxMin(mass);