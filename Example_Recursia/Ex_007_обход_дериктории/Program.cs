// Обход дериктории
/*
string path = "C:/Users/Уважаемый/Desktop/програмирование/5A знакомство с базами данных/сименар3";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/


string NumbersFor(int a, int b)
{
 string result = String.Empty;
 for (int i = a; i <= b; i++)
 {
 result += $"{i} ";
 }
 return result;
}
string NumbersRec(int a, int b)
{
 if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
 else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10