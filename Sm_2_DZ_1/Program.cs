﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Привет! Покажу тебе вторую цифру трёхзначного числа. Введи число:");
int numA = Convert.ToInt32(Console.ReadLine ());
if (numA>99 && numA<1000 ) // Проверяем условие
{int numB = numA % 100;// убираем первое число
int numC = numB / 10;// убираем 3 число
Console.Write(numC);// Выводим 2 число
}
else  // иначе выводим ошибку
Console.WriteLine("Введи ТРЁХЗНАЧНОЕ число");