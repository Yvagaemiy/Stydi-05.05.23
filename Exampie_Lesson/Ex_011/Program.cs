Console.Clear();


int Max (int argy1, int argy2, int argy3)
{
      int result=argy1;
      if (argy2 > result) result=argy2;  
      if (argy3 > result) result=argy3;
      return result;  
}
int[] array = {15, 21, 3, 24, 581, 69, 7, 81, 39};

//array[4] =35;// щброщение к массиву
//Console.WriteLine(array[7]); // показывает число под индексом 7 массива

int result = Max(

Max(array[0],array[1],array[2]),
Max(array[3],array[4],array[5]),
Max(array[6],array[7],array[8])
);
Console.WriteLine(result);



/*
int max1 = Max(a1, b1,c1);
int max2 = Max(a2, b2,c2);
int max3 = Max(a3, b3,c3);
int max = Max(max1, max2, max3);

 Console.WriteLine(max);
*/