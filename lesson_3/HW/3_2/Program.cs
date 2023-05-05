Console.WriteLine ("Введите пяти значное число: ");
string num = Console.ReadLine();
int число = num.Length;

if (число == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine(num + " Палиндром");
    }

    else
    {
        Console.WriteLine(num + " Не палиндром");
    }
}