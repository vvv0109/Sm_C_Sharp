//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
Console.Clear(); //Очищаем терминал
int numA=new Random().Next(5,5);
int numB (int n)
{
if(n>numA) return numA;
else return n-1;
}
for (int i=numA+1, r=1; r<i; i--)
Console.Write(numB(i));
