Console.Clear();// автомотически чистит терминал
//Console.SetCursorPosition(10, 4); // отступ от левого края 10 отступ от верхнего 4
//Console.WriteLine("+");

//Не получился код!!!

int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;

Console.SetCursorPosition(xa, ya);

Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);

Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);

Console.WriteLine("+");


int x = xa , y= xb;

int count = 10;

while (count < 10)
{

    int n = new Random().Next(0, 3); 

if (n == 0 )
 {
    x = (x+xa) / 2;

     y = (y+ya) / 2;
 }

 if (n == 1 )
 {
    x = (x+xb) / 2;

     y = (y+yb) / 2;
 }


 if (n == 2 )
 {
    x = (x+xc) / 2;

     y = (y+yc) / 2;
 }
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;
}