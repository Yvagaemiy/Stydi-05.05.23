// Задача 2: Напишите программу, которая 
//принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D 
//пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("x1= ") ;
int x1 = int.Parse(Console.ReadLine()!) ;

Console.WriteLine("y1= ") ;
int y1 = int.Parse(Console.ReadLine()!) ;

Console.WriteLine("x2= ") ;
int x2 = int.Parse(Console.ReadLine()!) ;

Console.WriteLine("y2= ") ;
int y2 = int.Parse(Console.ReadLine()!) ;

double Length (int x1, int y1, int x2, int y2 )
{
   return Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)), 3);

}
Console.WriteLine(Length ( x1,  y1,  x2,  y2 ) ) ;

//Вариант с лекции

//double Distance(int x1, int y1, int x2, int y2)
//{
 //   return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//}

//int x_1 = int.Parse(Console.ReadLine()!);
//int y_1 = int.Parse(Console.ReadLine()!);
//int x_2 = int.Parse(Console.ReadLine()!);
//int y_2 = int.Parse(Console.ReadLine()!);

// 3, 6, 2, 1
// 7, -5, 1, -1
//Console.WriteLine(Distance(x_1, y_1, x_2, y_2));