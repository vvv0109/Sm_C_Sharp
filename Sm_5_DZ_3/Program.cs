﻿//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear(); //Очищаем терминал
Console.WriteLine("Привет! Покажу сумму чисел в массиве, стоящих на нечётных местах, введи число:"); //Выводим смысл
int numA = Convert.ToInt32(Console.ReadLine ());// вводим размер массива
double[] numB= new double[numA];//объявлем массив размера 
double[] numС= new double[numA];//объявлем массив размера 
double sum1=0;
double sum2=0;

for (int i=0; i<numA ; i++)//цикл
{
    numB[i]=new Random().Next(-999,1000);//Генерерируем случайное число и записываем его в индекс i
    numС[i]=new Random().Next(-999,1000);//Генерерируем случайное число и записываем его в индекс i
    numB[i]=numB[i]/10+numС[i];// Создаем Массив вещественных чисел
    Console.Write(" " + numB[i]);// выводим элемент массива, включи если нужно
    if (numB[i]>sum1)//Находим Максимальное
    { 
        sum1=numB[i];//Запоминаем максимальное
    }
    if (numB[i]<sum2)//Находим минимальноне
    { 
        sum2=numB[i];//Запоминаем минимальное
    }
}
double sum3=sum1-sum2;
//Console.Write (" Min= " + sum2 + " Мах= "+ sum1);// Показать мин и макс
Console.Write (" Разница между максимальным и минимальным= " + sum3);// Итог