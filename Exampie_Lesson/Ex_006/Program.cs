// Приветствие
Console.WriteLine("Введите имя : ");

string usename = Console.ReadLine();

if (usename.ToLower() == "маша")//.ToLower() оператор переводит все символы в нижни регистор (можно по любому написать имя)
{
Console.WriteLine("ура это же Маша! ");

}
 else 
 {
    Console.Write("привет : ");
    Console.WriteLine(usename);
 } 

