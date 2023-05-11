//Факториал

int FactorialFor(int n)
{
   int resulte = 1;
   for( int i =1;i <= n ;i++) resulte *=i;
   return resulte;
}
int FactorialRec(int n)
{
    if(n==1) return 1;
    else return n* FactorialRec(n-1);
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));