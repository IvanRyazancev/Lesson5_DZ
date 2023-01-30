//Задача №2. Показать числа Фибоначчи.

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

Console.Write("Введите кол-во элементов последовательности Фибоначчи: ");
int length = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= length; i++)
{

    Console.Write(Fibonacci(i));
}