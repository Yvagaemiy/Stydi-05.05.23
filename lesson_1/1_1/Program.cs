// 1. Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом 
//  второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет
//3. Напишите программу, которая будет выдавать 
//название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

int num1 = 0; // вводим переменную 1
int num2 = 0; // вводим переменную 2

Console.WriteLine("please enter number1 n1 = "); // просим вести пользователя первую любую цифру в строку
num1 = int.Parse(Console.ReadLine()!) ; // переворот строки в целое  действие для консоли 

Console.WriteLine("please enter number1 n2 = "); // просим вести пользователя вторую любую цифру в строку
num2 = int.Parse(Console.ReadLine()!); // переворот строки в целое  действие для консоли 

if ((num2 *num2) ==num1) // умнажаем число само на себя и получаем первое введенное число. если да то выводит нет
{
   Console.WriteLine("Yes!"); 
}
else // если иное выводит нет
{
  Console.WriteLine("No!");  
}

//int num1 = 0;
//int num2 = 0;

//сonsole.WriteLine("Please enter num1 num1 = ");
 //num1 = int.Parse(Console.ReadLine()!);

//Console.WriteLine("Please enter num2 num2 = ");
 //num2 = int.Parse(Console.ReadLine()!);

//if (num2 * num2 == num1)
//{
//   Console.WriteLine("Yes!"); 
//}
//else
//{
//    Console.WriteLine("No!");
//}
