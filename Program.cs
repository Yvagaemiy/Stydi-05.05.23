

 /*double пи =3.1415;
int NBackingFleld;
void SetMyProperty(int value)
{
    KBackingField = value;
}
int GetMyProperty()
{
    return KBackingField;
}
int NewMyProperty{get; set; }*/

/*void DrawText(string text, int left , int top);
{
        Console.SetCursorPosition(left,top);
        Console.WriteLine(text);
}
DrawText("intensive c# Demo text" , 629, 360  );

int text = int.Parse(Console.ReadLine()!);
int left = int.Parse(Console.ReadLine()!);
int top = int.Parse(Console.ReadLine()!);*/

/*int text=caption;
int left=screenWidthPosition;
int top=screenHeightPosition;
int DrawText( );

string caption = "intensive c# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeightPosition = Console.WindowHeigh  / 2;*/

using System.Linq;


string text = "(1,2) (3,4) (5,6) (7,8)"
        .Replace ("(", "")
        .Replace (")", "")
        ;

Console.WriteLine(text);
var data = text.Split(" ")
            .Select (item=> item.Split(','))
            .Select (e=>(x: int.Parse(e[0]), y: int.Parse(e[1]) ))
            .ToArray();

for (int i = 0;i < data.Length; i++ ) 
{
   // for ( int k = 0; k < data[i].Length ; k++)
      //  {
       //         Console.WriteLine(data[i][k]);
      //  }
    //Console.WriteLine(); 

    Console.WriteLine(data[i]. x * 10);
    
     Console.WriteLine(data[i]. y + 2);
     Console.WriteLine();
}           
   
