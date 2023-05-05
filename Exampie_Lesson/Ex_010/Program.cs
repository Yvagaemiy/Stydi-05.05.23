 
Console.Clear();


int Max (int argy1, int argy2, int argy3)


{
      int result=argy1;
      if (argy2 > result) result=argy2;  
      if (argy3 > result) result=argy3;
      return result;  
}

int a1 = 10;
int a2 = 7;
int a3 = 13;
int b1 = 19;
int b2 = 35;
int b3 = 21;
int c1 = 322;
int c2 = 28;
int c3 = 23;


int max1 = Max(a1, b1,c1);
int max2 = Max(a2, b2,c2);
int max3 = Max(a3, b3,c3);
int max = Max(max1, max2, max3);

 Console.WriteLine(max);




/*

int a1 = 10;
int a2 = 7;
int a3 = 13;
int b1 = 19;
int b2 = 35;
int b3 = 21;
int c1 = 3;
int c2 = 28;
int c3 = 23;

int max = a1;

if (b1 > max)  max = b1 ;
if (c1 > max)  max = c1 ;

if (a2 > max)  max = a2 ;
if (c2 > max)  max = c2 ;
if (b2 > max)  max = b2 ;

if (a3 > max)  max = a3 ;
if (b3 > max)  max = b3 ;
if (c3 > max)  max = c3 ;   



Console.WriteLine(max);

*/