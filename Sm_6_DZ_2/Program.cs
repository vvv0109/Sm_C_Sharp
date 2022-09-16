//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear(); //Очищаем терминал
Console.WriteLine("Привет! Найду точку пересечения двух прямых, Введи значения b1, k1, b2 и k2: "); //Выводим смысл
double b1 = Convert.ToInt32(Console.ReadLine ()); // Вводим
double k1 = Convert.ToInt32(Console.ReadLine ()); // Вводим
double b2 = Convert.ToInt32(Console.ReadLine ()); // Вводим
double k2 = Convert.ToInt32(Console.ReadLine ()); // Вводим
/*k1 * x + b1 = k2 * x + b2
k1x-k2x=b2-b1
-(1/х)=k2-k1+b2-b1
(k1-k2)х=b2-b1
х=b2-b1/k1-k2
y = k2 * b2-b1/k1-k2 + b2
*/
double x = (b2-b1)/(k1-k2);
double y = k2 * x + b2;

Console.WriteLine("Точка пересечения (Х= "+x+"; У= "+y+")");
