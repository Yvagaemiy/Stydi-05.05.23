Console.Clear();
 

/*Console.Write("Введите число 1: ");
double num1 = double.Parse(Console.ReadLine()!);


double num2 = new Random().Next (1, 100);
Console.Write(" число 2: ");
Console.WriteLine(num2);

  if (num1>num2)
{
    Console.Write("Ответ: ");
    Console.WriteLine(num1/num2);
}
  else
{
    Console.Write("Ответ: ");
    Console.WriteLine(num2/num1);

}

*/



/*double result = num1 / num2;

Console.Write("Ответ: ");
Console.WriteLine(result);
*/
/*
int a = 101;
int b = 3;
int c = 14;
int max = a;
//if (a > max)
//{
 //   max == a;
//}
    
if (b > max)
    {
        max = b;
    }
if (c > max)
    {
        max = c;
    }
    Console.Write("Ответ: ");
   Console.WriteLine(max); 

*/
/*
Console.WriteLine("Введите имя");

string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
  Console.WriteLine("Ура это же Маша!");
}
else 
Console.Write("Привет: ");
Console.WriteLine(username);

*/

/*

int xa = 70;
int ya = 1;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

int xb = 30;
int yb = 15;

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

int xc = 110;
int yc = 15;

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa , y= ya;

int count = 0;

while (count < 10000)
{

int массив = new Random().Next(0, 3);

     if (массив == 0)
     {
     x = (x + xa)/2;
     y = (y + ya)/2;
     }

      if (массив == 1)
     {
     x = (x + xb)/2;
     y = (y + yb)/2;
     }

      if (массив == 2)
     {
     x = (x + xc)/2;
     y = (y + yc)/2;
     }

Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;
}

*/

Console.Write("Введите имя:");
string username = Console.ReadLine();

    if(username.ToLower() =="маша")
{
     Console.Write("Ура Маша ");
}
      else
{
      Console.Write("Привет: ");
      Console.WriteLine(username);
}


