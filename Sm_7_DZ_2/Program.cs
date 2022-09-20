//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear(); //Очищаем терминал
Console.WriteLine("Привет! Введи номер строки: "); //Выводим смысл
int numF = Convert.ToInt32(Console.ReadLine ()); // Вводим 
Console.WriteLine("Привет! Введи номер солбца: "); //Выводим смысл
int numG = Convert.ToInt32(Console.ReadLine ());// Вводим 
int numA=new Random().Next(2,10);
int numC=new Random().Next(2,10);
double [,] matrix=new double [numA, numC];
double numD=0, numW=0, numQ=0;
for (int i=0; i<matrix.GetLength(0); i++)
{    Console.Write("[");
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        numD=(new Random().Next(-10,10));//интервал чисел 
        //numD=numD/10%2;// включи если интервал больше -10 +10
        numD=numD/10;// выключи если интервал больше -10 +10
        matrix[i,j]=numD;//выключи если интервал больше -10 +10 "+new Random().Next(1,3);"
        Console.Write($"{matrix[i,j]} ");// выводим элемент массива 
        if ((j)==numG-1 && (i+1)==numF)// убери -/+1 если хочешь искать по индексу с 0
        {
        //Console.Write ("!"+numD+"! ");// включи что бы видеть число в массиве 
        numW++;
        numQ=numD;
        }  
        
    }
    
    Console.Write("]");
    Console.WriteLine();
    
}
if (numW==0)
{
Console.Write ("Попробуй еще раз, такого элемента нет");
}
else 
{
Console.Write ("Число в массиве- "+numQ);
}
