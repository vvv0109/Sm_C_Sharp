// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear(); //Очищаем терминал
Console.WriteLine("Привет! Покажу тебе расстояние между точками в 3D пространстве. Координаты:"); //Выводим смысл
Console.Write ("Х1- ");
int numA = Convert.ToInt32(Console.ReadLine ()); // Вводим число
Console.Write("У1- ");
int numB = Convert.ToInt32(Console.ReadLine ()); // Вводим число
Console.Write ("Z1- ");
int numC = Convert.ToInt32(Console.ReadLine ()); // Вводим число
Console.Write ("Х2- ");
int numD = Convert.ToInt32(Console.ReadLine ()); // Вводим число
Console.Write ("У2- ");
int numI = Convert.ToInt32(Console.ReadLine ()); // Вводим число
Console.Write ("Z2- ");
int numF = Convert.ToInt32(Console.ReadLine ()); // Вводим число
int numR=0;
numR=(((numD-numA)*(numD-numA))+((numI-numB)*(numI-numB))+((numF-numC)*(numF-numC))); // расчёт по формуле
double v = Math.Sqrt(numR); // извлекаем корень
Console.WriteLine (v); //вывод