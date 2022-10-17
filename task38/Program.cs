/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите значение длины массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

double[] array = new double[userNumber];

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 10;
}

PrintArray(array);


for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

void PrintArray(double[] array) // "метод", который будет печатать массив //
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.Write($"]");
}

Console.WriteLine($" -> max = {max}, min = {min}, разница = {max - min}");
