//Пирамида


void Towers(string with = "1", string on = "4", string some = "2",string some1 = "3", int count = 5)
{
 if (count > 1) Towers(with, some,some1, on, count - 1);
 
 Console.WriteLine($"{with} >> {on}");
 
 if (count > 1) Towers(some,some1, on, with, count - 1);
}

Towers();