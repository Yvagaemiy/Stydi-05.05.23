//Задача 1: Напишите программу, которая принимает 
//на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int SumNum(int num)
{
    int sum_all = 0;

    for (int i =1; i <=num; i++ )

    sum_all += i;
  
    return sum_all; 

}

int va1 = int.Parse(Console.ReadLine()!) ;
int result = SumNum(va1);
Console.WriteLine(result);