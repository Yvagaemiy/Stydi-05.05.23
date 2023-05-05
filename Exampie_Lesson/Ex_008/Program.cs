Console.Clear();
//Console.SetCursorPosition(50, 4);
//Console.WriteLine("+");
// внимательно с размером экрана!!!

 int   xa = 70;
 int   ya = 1;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

 int   xb = 1;  
 int   yb = 21;
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

 int   xc = 140;
 int   yc = 21;

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0; 

while( count <100000) //какое количество раз надо проделать эту операцию
{
    int waht = new Random().Next(0, 3);//[1,2,3]
    if (waht ==0)
    {
            x = (x + xa) / 2 ;
            y = (y + ya) / 2 ;

    }
    if (waht ==1)
    {
            x = (x + xb) / 2 ;
            y = (y + yb) / 2 ;

    }
    if (waht ==2)
    {
            x = (x + xc) / 2 ;
            y = (y + yc) / 2 ;

    }
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
        count++;//чтобы счетчик делал повторения

}
