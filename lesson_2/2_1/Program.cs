// 2. Напишите программу, которая выводит 
//случайное число из отрезка [10, 99] и показывает 
//наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8
// Не получилось !!!

int num = GenerateNumber();

int didgit1 = GetFirstDigit(num);
int didgit2 = GetSecondDigit(num);
int max = FindMax(didgit1, didgit2);

 

int GenerateNumber()
{
     int number = new Random().Next(10, 100);  
    return number;// возврощаем число целое т.к int
}
int GetSecondDigit(int num)
{
    return num%10;
}
int GetFirstDigit(int num)
{
    return num/10;
}
int FindMax(int num1, int num2)
{
 if (num1 > num2)
 {
      return num1;
 }
  return num2;
}



Console.WriteLine(" your max : "  + num);







