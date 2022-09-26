//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
Console.Clear(); //Очищаем терминал
int numA=new Random().Next(3,10);
int numF=numA, numC=numA, numD=0;
int[,,] matrix = new int[numA, numF, numC];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int z = 0; z < matrix.GetLength(1); z++)
        {
            Console.WriteLine();
            for (int w = 0; w < matrix.GetLength(2); w++)
            {
                numD=(new Random().Next(10,100));//интервал чисел      
                matrix[i, z, w]=numD;
                Console.Write($"{matrix[i, z, w]}({i},{z},{w}) ");
            }
        }
    }
