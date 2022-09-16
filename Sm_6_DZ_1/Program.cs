//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear(); //Очищаем терминал
Console.Write("Привет! Покажу сколько чисел больше 0, Введи кол-во цифр: "); //Выводим смысл
int numA = Convert.ToInt32(Console.ReadLine ()); // Вводим кол-во чисел
int[] numB=new int [numA];//объявлем массив размера
int s=0, i=0;
for (int e=1, numC=0; numA>i; i++, e++)
{
    Console.Write("Введи "+ e +" число: ");
    numC=Convert.ToInt32(Console.ReadLine ());
    numB[i]=numC;
    //Console.WriteLine (numB[i]);
    if (numB[i]>0)
    {
        s++;
    }
}
Console.Write("В веденных значениях: ");
for(i = 0; i< numA; i++) // Запускаем цикл для вывода массива на экран
{
    Console.Write( $"{numB[i]}"+";"); // Функция вывода
}
Console.WriteLine();
Console.WriteLine(s +" положительных чисела.");