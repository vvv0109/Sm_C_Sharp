// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear(); //Очищаем терминал
Console.WriteLine("Привет! Покажу тебе возведение в степень. Введи число, которое нужно возвести в степень:"); //Выводим смысл
int numA = Convert.ToInt32(Console.ReadLine ()); // Вводим число
Console.WriteLine(" Введи степень:"); //Выводим смысл
int numB = Convert.ToInt32(Console.ReadLine ()); // Вводим число
for (int index=1, W=numA; index<numB; numA=numA*W, index++);//выполнять столько раз, пока индекс меньше степени, умнажать 1/2/3... итог на введеное число
Console.WriteLine ("Результат- " + numA);//вывод