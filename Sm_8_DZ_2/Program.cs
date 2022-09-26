//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear(); //Очищаем терминал
int numA=new Random().Next(2,15);
int numC=numA;
int[,] matrix = new int[numA, numC];
int numD=0, numZ=0,numR=0, w=0;
int[] matrixE=new int[numA];
numA=numA;
for (int i=0; i<matrix.GetLength(0); i++)
{    Console.Write("[ ");
numR=numZ;
numZ=0;
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        numD=(new Random().Next(1,10));//интервал чисел      
        matrix[i,j]=numD;
        numZ=numD+numZ;
        Console.Write($"{matrix[i,j]} ");// выводим элемент массива
    }
   Console.Write("]");
   Console.WriteLine();
   matrixE[w]=numZ;
   w++;
}
Console.WriteLine();
int max=0;
for (int j=0; j<numA; j++)
{
    if (matrixE[j]>max) 
    {
    max = matrixE[j];
    }
}
for (int j=0, q=0; j<numA; j++)
{ q++;
    if (matrixE[j]==max) 
    {
    Console.WriteLine("Сумма элементов "+ max+ " Строчка № "+q);
    }  
}
 