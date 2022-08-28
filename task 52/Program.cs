//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine ("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,]array =new int [m,n];// создаем новый массив
int [,]arrayRez = InitArray(array, m, n);
PrintArray(arrayRez); //заполняем массив
double [] arithmetic = arithmeticMean(arrayRez, m);


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

double[] arithmeticMean(int[,]array, int m)
{
    double [] arrayResult = new double [array.GetLength(0)];
    double arithmeticMean=0;
    for (int j=0; j<array.GetLength(1);j++) 
    {
        for (int i = 0; i < array.GetLength(0); i++)
    {
        arithmeticMean += array[i, j];
    
    }
    arrayResult[j] = arithmeticMean / m;
    arithmeticMean=Math.Round(arrayResult[j],3);
    Console.WriteLine ($"Среднее арифметическое {j} столбца: {arithmeticMean},");
    arithmeticMean=0;
}
    
    return arrayResult;
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






