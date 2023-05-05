// Задача 2: Напишите программу, которая 
//принимает на вход число N и выдаёт 
//произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120
double Factorial (int n) 

{     //1!-0
      //0!=0

if (n==1) return 1;

else return n * Factorial (n-1);
}
    for(int i = 1 ; i< 10 ; i++)
    
    {

       Console.WriteLine($"{i}! = {Factorial(i)}");//формула показывает факториал от чего
    }
