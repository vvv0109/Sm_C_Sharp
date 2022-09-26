//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear(); //Очищаем терминал
int numA=new Random().Next(4,15);
int numC=new Random().Next(4,15);
int[,] matrix = new int[numA, numC];
int numD=0;
for (int i=0; i<matrix.GetLength(0); i++)
{    Console.Write("[ ");
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        numD=(new Random().Next(1,1000));//интервал чисел      
        matrix[i,j]=numD;
        Console.Write($"{matrix[i,j]} ");// выводим элемент массива
    }
    Console.Write("]");
    Console.WriteLine();
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int v = 0; v < matrix.GetLength(1) - 1; v++)
        {
            if (matrix[i, v] <matrix[i, v + 1]) 
            {
                int TY = 0;
                TY = matrix[i, v];
                matrix[i, v] = matrix[i, v + 1];
                matrix[i, v + 1] = TY;
            }
        }
    }
}
Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }



