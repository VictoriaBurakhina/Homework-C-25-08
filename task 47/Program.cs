//. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

Console.Clear();
Console.WriteLine ("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

double [,]array =new double[m,n];// создаем новый массив
double [,]arrayRez = InitDoubleArray(array, m, n); //заполняем массив
PrintArray(arrayRez);//выводим массив

//создаем двумерный массив double
double[,] InitDoubleArray(double [,] array, int m, int n)
{
  double [,] resultArray = new double [m, n];
    for(int i=0; i<m;i++)
    {
        for(int j=0; j<n;j++)
        {
         resultArray[i,j] = new Random().NextDouble() ;
         resultArray[i,j] = Math.Round(resultArray[i,j], 2);
        }
    }
    return resultArray;  
}
void PrintArray (double[,]doubleArray)
{
for (int i = 0;i<doubleArray.GetLength(0);i++)
{
  for ( int j = 0; j<doubleArray.GetLength(1);j++)
  {
    Console.Write($"{doubleArray[i,j]} ");
  }
Console.WriteLine();
}
}



