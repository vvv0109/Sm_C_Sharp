Console.Clear(); //Очищаем терминал
Console.WriteLine("Привет! Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N."); //Выводим смысл
int numA = Convert.ToInt32(Console.ReadLine ()); // Вводим число Х точка1
int index=0;
int numR=2;
while (index<numA)
{
    numR=index*index;
    index++;
    Console.WriteLine (numR);
}

