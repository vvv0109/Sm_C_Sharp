// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear(); //Очищаем терминал
Console.WriteLine("Привет! Покажу тебе таблицу кубов чисел от 1 до N. Введи число:"); //Выводим смысл
int numA = Convert.ToInt32(Console.ReadLine ()); // Вводим число
//int index=0;
//int numE=1;
//int numZ=0;
for (int index=0, numZ=0, numE=1; index<numA; numZ=numE*numE*numE, index++, numE++, Console.WriteLine(numZ));
