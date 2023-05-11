int n = 1;
void FindWords(string aлфовит, char[] слова,int length = 0)
{
    if(length == слова.Length)
    {
            Console.WriteLine($"{n++}{new String(слова)}");
            return;
    }
    for(int i =0; i < aлфовит.Length;i++)
    {
        слова[length] = aлфовит[i];
        FindWords( aлфовит,  слова, length + 1);
    }
}

FindWords("алиса" , new char[2]);