//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear(); //Очищаем терминал
int numA=new Random().Next(2,5);
int numC=new Random().Next(2,5);
int [,] matrix=new int [numA, numC];
int numD=0, T=0;
for (int i=0; i<matrix.GetLength(0); i++)
{    Console.Write("[");
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        numD=(new Random().Next(-10,10));//интервал чисел 
        matrix[i,j]=numD;
        Console.Write($"{matrix[i,j]} ");// выводим элемент массива       
    }
    Console.Write("]");
    Console.WriteLine();
}
while (T<numC)//цикл сколько в строке сивалов
{
    int Z=0, U=0, Q=0;
    double numW=0;
    while (numA>Z)//считаем по порядку в столбце
{
    Q=matrix[U,T];
    numW=Q+numW;//складываем предыдущий элемент и следующий
    Z++;
    U++;
    //Console.Write ("!"+numW+"!");//порядок сложения
}
Console.WriteLine (" Cреднее арифметическое в столбце №" + (T+1) + "= " +numW/Z); 
T++;
}
