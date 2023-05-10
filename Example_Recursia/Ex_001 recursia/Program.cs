
//Собрать строку с числами от a до b, а Б=b
string NumbersFor (int a , int b)
{
    string result = String.Empty;

    for (int i = a ;a < b;i++)
    {
        //Console.WriteLine(Numbers);
        result += $"{i}";
    }
      return result;
}
string NumbersRec (int a , int b)
{
     if ( a<=b ) return $"{a}" + NumbersRec(a+1 , b);//надо доделать
     else return String.Empty;
}
Console.WriteLine(NumbersFor(1 , 10));
Console.WriteLine(NumbersRec(1 , 10));





