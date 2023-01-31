//Задача №4. Написать программу копирования массива.

Console.Write("Введите длину исходного массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];                           //Создание исходного массива

for (int i = 0; i < array.Length; i++)              //Заполнение исходного массива
{
    array[i] = new Random().Next(-99, 99);
}

int[] new_array = new int[array.Length];           //Создание нового массива
Array.Copy(array, new_array, array.Length);        //Копирование элементов родительского массива в новый массив
//Array.Reverse(new_array);                        //Эта строчка для проверки того, что значения действительно скопированы в новый массив

Console.Write("Исходный массив:      ");
Console.Write(String.Join(" | ", array));          //Вывод исходного массива
Console.WriteLine();
Console.Write("Скопированный массив: ");
Console.Write(String.Join(" | ", new_array));      //Вывод скопированного массива