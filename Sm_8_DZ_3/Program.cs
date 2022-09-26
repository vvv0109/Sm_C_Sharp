//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear(); //Очищаем терминал
int numA=new Random().Next(3,3);
int numC=numA;
int[,] matrix = new int[numA, numC];
int[,] matrixE = new int[numA, numC];
int[,] matrixC = new int[numA, numC];
int numD=0;
Console.WriteLine("Матрица 1");
for (int i=0; i<matrix.GetLength(0); i++)
{    Console.Write("[ ");
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        numD=(new Random().Next(1,3));//интервал чисел      
        matrix[i,j]=numD;
        Console.Write($"{matrix[i,j]} ");// выводим элемент массива
    }
   Console.Write("]");
   Console.WriteLine();
}
Console.WriteLine("Матрица 2");
for (int i=0; i<matrixE.GetLength(0); i++)
{    Console.Write("[ ");
    for (int j=0; j<matrixE.GetLength(1); j++)
    {
        numD=(new Random().Next(10,100));//интервал чисел      
        matrixE[i,j]=numD;
        Console.Write($"{matrixE[i,j]} ");// выводим элемент массива
    }
   Console.Write("]");
   Console.WriteLine();
}
for (int i = 0; i < numA; i++)
{
    for (int j = 0; j < numA; j++)
    {
        for (int k = 0; k < numA; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrix[i, k] * matrixE[k, j]); 
        }
    }
}
Console.WriteLine("Итого 3");
for (int i=0; i<matrixC.GetLength(0); i++)
{    Console.Write("[ ");
    for (int j=0; j<matrixC.GetLength(1); j++)
    {
        Console.Write($"{matrixC[i,j]} ");// выводим элемент массива
    }
   Console.Write("]");
   Console.WriteLine();
}
