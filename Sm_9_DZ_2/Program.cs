//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear(); //Очищаем терминал
int numA=new Random().Next(1,1);
int numC=new Random().Next(15,15);
void numB (int sum)
{
if (numA > numC) 
{
    Console.WriteLine(sum); 
    return;
}
    sum = sum + (numA++);
    numB(sum);
}
numB(0);
