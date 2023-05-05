// Задача 2: Напишите программу, которая выводит 
//случайное трёхзначное число и удаляет вторую цифру 
//этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
int num = new Random().Next(100, 1000);

Console.WriteLine(num);

//int result = (num % 10);

int result1 = (num % 10);

 //Console.WriteLine(result1);

  int result2 = (num / 100);

 //Console.WriteLine(result2);  
  
 int result3 = (result2 * 10 + result1);
 
Console.WriteLine(result3); 







