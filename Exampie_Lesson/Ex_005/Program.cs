//Рондом
//1) задается интервал

/*
int num1 = new Random().Next(1, 20);//задается интервал
Console.Write("число 1 : ");
Console.WriteLine(num1);


Console.Write("число 2 : ");
int num2 = new Random().Next(20, 40);//задается интервал
Console.WriteLine(num2);


int resulte = (num1+num2);
Console.Write("сумма : ");
Console.WriteLine(resulte);

*/

//2) с лекций

int num1 = new Random().Next(1, 20);

int num2 = new Random().Next(20, 40);

int resulte = num1 + num2;

Console.WriteLine(resulte);