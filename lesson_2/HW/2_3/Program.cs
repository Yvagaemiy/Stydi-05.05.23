//Задача 4: Напишите программу, которая принимает на 
//вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да 
//7 -> да 
//1 -> нет
Console.Write("введите числo :");
int num = int.Parse(Console.ReadLine()!); 
if (num ==6)
{
   Console.Write("Да");
}
 else if(num ==7)
 {
   Console.Write("Да");
}
else 
{
    
   Console.Write("Нет");
}
