//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear(); //Очищаем терминал
Console.WriteLine("Привет! Введи размер массива: "); //Выводим смысл
int numA = Convert.ToInt32(Console.ReadLine ()); // Вводим 
int numC = Convert.ToInt32(Console.ReadLine ());// Вводим 
double [,] matrix=new double [numA, numC];
double numD=0;
for (int i=0; i<matrix.GetLength(0); i++)
{Console.Write("[");
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        numD=(new Random().Next(-10,10));//интервал чисел 
        //numD=numD/10%2;// включи если интервал больше -10 +10
        numD=numD/10;// выключи если интервал больше -10 +10
        matrix[i,j]=numD+new Random().Next(-10,10);//выключи если интервал больше -10 +10 "+new Random().Next(1,3);"
        Console.Write($"{matrix[i,j]} ");// выводим элемент массива   
    }
    Console.Write("]");
    Console.WriteLine();
}
