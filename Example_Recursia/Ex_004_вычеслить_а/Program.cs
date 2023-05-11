// ВЫчислить а


int PowerFor(int a ,int n)
{
   int resulte = 1;
    for (int i = 1;i<= n;i++) resulte *= a;
    return resulte;
}
int PowerRec(int a, int n)
{
   if (n==0) return 1;
   else return PowerRec(a, n-1)* a;
}
Console.WriteLine(PowerFor(2, 10));

Console.WriteLine(PowerRec(2, 10));