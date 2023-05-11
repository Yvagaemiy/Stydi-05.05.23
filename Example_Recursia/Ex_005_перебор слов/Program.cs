//Перебор слов

internal class Program
{
    private static void Main(string[] args)
    {
        char[] MassivSimvol = { 'a', 'и', 'в', 'с' };

        int count = MassivSimvol.Length;

        int n = 1;

        for (int i = 0; i < count; i++)
        {


            for(int j=0;j < count;j++)
            {
                Console.WriteLine($"{n++,-5}{MassivSimvol[i]}{MassivSimvol[j]}");
            }
        }
    }
}