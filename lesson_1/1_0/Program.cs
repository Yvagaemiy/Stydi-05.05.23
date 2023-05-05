// Напишите программу, которая на вход 
// принимает число и выдаёт его квадрат (число 
// умноженное на само себя).

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("write a nabure: ");

        int num = int.Parse(Console.ReadLine()!);

        Console.WriteLine(num * num);
    }
}