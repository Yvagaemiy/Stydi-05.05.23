// Обход дериктории
/*
string path = "C:/Users/Уважаемый/Desktop/програмирование/4A язык программирование/1 лекция/7 рекурсия продолжение";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/
//рекурсия которая  смотрит все папки


void CatalogInfo(string path, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(path);
 foreach (var currentCatalog in catalogs.GetDirectories())
 {
 Console.WriteLine($"{indent}{currentCatalog.Name}");
 CatalogInfo(currentCatalog.FullName, indent + " ");
 }
 foreach (var item in catalogs.GetFiles())
 {
 Console.WriteLine($"{indent}{item.Name}");
 }
}
string path = "C:/Users/Уважаемый/Desktop/програмирование/4A язык программирование/3 практика и ДЗ/Stydi-05.05.23";
CatalogInfo(path);
