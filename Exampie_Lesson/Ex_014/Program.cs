double Factorial (int n) 

{     //1!-0
      //0!=0

if (n==1) return 1;

else return n * Factorial (n-1);
}
    for(int i = 1 ; i< 10 ; i++)// 10 - число факториала
    
    {

       Console.WriteLine($"{i}! = {Factorial(i)}");//формула показывает факториал от чего
    }
