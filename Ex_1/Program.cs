//Задача №1. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.

Console.Write("Введите занчение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите занчение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите занчение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите занчение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine()!);

/*
y = k1 * x + b1;                         //Получаем системы уравнений и выражаем "x" и "y"
y = k2 * x + b2;
x = (b2 - b1) / (k1 - k2);               //Получаем координату "x" точки пересечения прямых
y = (k1 * (b2 - b1)) / (k1 - k2) + b1;   //Получаем координату "y" точки пересечения прямых
*/

if (k1 == k2 && b1 == b2)                //Проверка частного случая совпадения прямых
{
    Console.Write("Прямые совпадают.");
}
else if (k1 == k2)                       //Проверка частного случая параллельности прямых
{
    Console.Write("Прямые параллельны.");
}
else                                     //Общий случай - пересечения прямых
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

    Console.Write($"Координата точки пересечения прямых [{Math.Round(x, 2)} ; {Math.Round(y, 2)}].");
}