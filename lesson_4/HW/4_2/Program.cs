// Задача 3: Напишите программу, которая задаёт массив из 
//8 элементов случайными числами и выводит их на экран. 
//Оформите заполнение массива и вывод в виде функции 
//(пригодится в следующих задачах)
//1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

void Print(int[] arr)        //Будет исползоватся для рандома ???
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num, start, stop);
Print(mass);




//int[] array = MekeArray();//делаю масив array rkfle gthtvtyye.
//PrintArray(array); //затем array масив печатаю


//int[] MekeArray()//1)int бокс с функцие(массив) называется Делай массив -метод который будет возврощать массив.
//внутри ни чего нет т.к. в задаче ровно 8 элементов.


//{

//int[] arr = new int[90];  //2)создать массив с именем arr который потом вернется инициализировав его,что в нем 8 элементов. 
//for(int i=0; i<90 ;i++)  //3)
    // {
    //    arr[i] = GenerateNembur();//этот масив заполняю что arr индексом i лежит рандомный метод int GenerateNembur();
    // }
   //    return arr; //затем верну arr 

//}


//int GenerateNembur() //Метод создания рондомного числа с функцией возврата
//{
 // int number = new Random().Next(0 , 100);
 // return number;

//}

//void PrintArray(int[] array) //Метод пустой который будет принимать в себя какойто массив array
// ни чего не возврощает? он только выводит на экран массив
//{
  // for(int i=0; i< array.Length;i++ )
  //   {

    ///    Console.Write($"{array[i]} ");//$ выводит конкретную переменную которую можно будет увидить сдесь мы выводим массив
        //array с переменной i которая имеет длину 8 чисел.Метод выводит поочереди все 8 чисел в строку.
  //   }
     //   Console.ReadLine();//перенос на новую страку 
//}

