

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
        .RepLace("(", "")
        .RepLace(")", "")
        ;

Console.WriteLine(text);
var data = text.Split(" ")

            .ToArray();

for (int i = 0;i < data.Length; i++ ) 
{
Console.WriteLine(data[i]);

}           
   
