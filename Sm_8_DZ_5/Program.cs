//Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Clear(); //Очищаем терминал
int numA=new Random().Next(4,5);
int numC=numA;
int[,] matrix = new int[numA, numC];
int numD=0, w=0;
for (int i=0; i<matrix.GetLength(0); i++)
{    Console.Write("[ ");
    for (int z=0; z<matrix.GetLength(1) && i==0; z++)
    {
        numD++;//интервал чисел      
        matrix[i,z]=numD;
    }
    w=i;
    for (int z=0; z<matrix.GetLength(0); z++)
    {
        matrix[i,numC-1]=numD;
       Console.Write($"{matrix[i,z]} ");// выводим элемент массива
    }
    numD++;
    i=w;
    for (int z=0; z<matrix.GetLength(1); z++)
    {
        matrix[z,numC-1]=numD;
    }
      
   Console.Write("]");
   Console.WriteLine();
}
