﻿//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear(); //Очищаем терминал
Console.WriteLine("Привет! Покажу тебе сумму цифр в числе. Введи число:"); //Выводим смысл
int numA = Convert.ToInt32(Console.ReadLine ()); // Вводим число
int Q=0, numС=10, numD = numA, numB = numA, numF=1, numW=numA;
int numS=0,sum=0, numG=10, indexW=0,numR = 0;
while (numW > 0) // запускаем цикл проверки сколько значений введено
    {
    numW = numW / 10; // делим введёное значение столько раз, пока не получим 0
    indexW++; //счётчик
    }
while (indexW>numR) // запускаем цикл перевода кол-во цифр в формат 1000...
    {
    numF =numF*10; //перевода кол-во цифр в формат 1000...
    numR++; //счётчик
    }
indexW=indexW-1; //нужно прервать цикл на предпоследнем элементе, т.к. делить на 0 нельзя 
numF=numF/10;//уменьшаем т.к. проверка начинается с 1 числа ряда
if (numF==10) // проверяем условие, если два числа
{
numS=numD/numF; // находим первое число
numW=numA%numС; // находим последнее число
//Console.WriteLine(numS); // включи если хочешь видеть первое  число
//Console.WriteLine(numW); // включи если хочешь видеть последнее число
Q=numS+numW;
}
else 
{
numS=numD/numF; // находим первое число
//Console.WriteLine(numS); // включи если хочешь видеть последнее  число
Q=numS;
}
if (numF>10)
{
    while (sum<indexW) // вводим цикл столько раз, сколько у нас цифр в ряд и проверяем каждую пару на равенство
    { 
        numС*=10;
        numF/=10;
        numS=numD/numF%numG; // находим  число
        //Console.WriteLine(numS+ "S");// включи если хочешь видеть число
        sum++;
        Q=numS+Q;
    }
}
Console.WriteLine("Сумма чисел- "+Q);
