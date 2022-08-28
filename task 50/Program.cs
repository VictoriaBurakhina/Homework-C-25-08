// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.(на вход именно поступает позиция элемента, можете разбить на две переменные или прописать в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет


Console.WriteLine ("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите позиции элемента");
int index1 = Convert.ToInt32(Console.ReadLine());
int index2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,]array =new int [m,n];// создаем новый массив
int [,]arrayRez = InitArray(array, m, n);
PrintArray(arrayRez); //заполняем массив
IndexPositionChecking(arrayRez,index1,index2);

//создаем двумерный массив 
int[,] InitArray(int [,] array, int m, int n)
{
int [,] resultArray = new int [m, n];
    for(int i=0; i<m;i++)
    {
        for(int j=0; j<n;j++)
        {
         resultArray[i,j] = new Random().Next(0,10) ;
         
        }
    }
    return resultArray;  
}
void IndexPositionChecking (int[,]array, int m, int n)
 {
    try{int result = array[m,n];
     if(m < array.GetLength(0) && n < array.GetLength(1))
    {
    Console.WriteLine($"Элемент с индексом ({m},{n}) равен {array[m,n]}");
    }  else
    {
       Console.WriteLine($"Элемента с индексом ({m},{n}) не существует в указанном выше массиве"); 
    }
     
    }catch(IndexOutOfRangeException e) {
        Console.WriteLine (e);
        Console.WriteLine ($"Такого элемента с индексом ({m},{n}) не существует в  массиве");
    }
 }    
 
 
void PrintArray (int[,]array)
{
for (int i = 0;i<array.GetLength(0);i++)
{
  for ( int j = 0; j<array.GetLength(1);j++)
  {
    Console.Write($"{array[i,j]} ");
  }
Console.WriteLine();
}
}