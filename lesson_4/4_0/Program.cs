//Задача 1: Напишите программу, которая принимает 
//на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int SumNum(int num)
{
    int count = 0;

    for (int i =1; i <=num; i++ )
{
    count = count +i;
}
    return count; 

}

// int va1 = int.Parse(Console.ReadLine()!) ;
// int result = SumNum(va1);
// Console.WriteLine(result);

Console.WriteLine("Ввидите число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"сумма чисел от {num} - > {SumNum( num)}");