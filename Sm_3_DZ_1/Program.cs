// Напишите программу, которая принимает на вход пятизначное (Усложнил, можно любое) число и проверяет, является ли оно палиндромом.
Console.Clear(); //Очищаем терминал
Console.WriteLine("Привет! Покажу тебе является ли число палиндромом. Введи пятизначное число:"); //Выводим смысл
int numA = Convert.ToInt32(Console.ReadLine ()); // Вводим число
int numС=10;
int numD = numA;
int numB = numA;
int numF=1;
int numW=numA;
int numS=0;
int sum=0;
int numY=1;
int numG=10;
int indexW=0;
int numR = 0;
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
indexW=indexW/2; //нужно проверить только половину ряда числа
numF=numF/10;//уменьшаем т.к. проверка начинается с 1 числа ряда
numW=numA%numС; // находим первое число
numS=numD/numF; // находим последнее число
//Console.WriteLine(numW); // включи если хочешь видеть первое  число
//Console.WriteLine(numS); // включи если хочешь видеть последнее число
while (sum<indexW && numW==numS) // вводим цикл столько раз, сколько у нас цифр в ряд и проверяем каждую пару на равенство
    {
        numY*=10;
        numС*=10;
        numF/=10;
        numW=numA%numС/numY;// находим  число
        numS=numD/numF%numG; // находим  число
        //Console.WriteLine(numW+ "W");// включи если хочешь видеть число
        //Console.WriteLine(numS+ "S");// включи если хочешь видеть число
        sum++;
    }
if (sum==indexW) // делаем вывод
{
    Console.WriteLine("число палиндромом");
}
else Console.WriteLine("число НЕ палиндромом");
