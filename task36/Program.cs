/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int[] getRandomArray(int length, int startPoint, int endPoint) // инициализация массива с заполнением случайными значениями
{
    int[] resultArray = new int [length];                      
    for (int i = 0; i < length; i++)                        
    {
        resultArray[i] = new Random().Next(startPoint, endPoint +1);
    }
    return resultArray;                                         
}

void printArray(int[] incomingArray) // функция выведения массива на экран
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {    
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length -1) // чтобы не было последней запятой
        {
            Console.Write(",");
        }
    }
    Console.Write("] -> ");
}

int getOddArrayElement(int[] incomingArray) // функция получения суммы значений элементов, находящихся на нечетных позизиях массиве
{
    int sum = 0;
    for (int i = 1; i < incomingArray.Length; i+=2)
    {
        sum = sum + incomingArray[i]; 
    }
    return sum;
} 

int[] currentArray = getRandomArray(4, -10,10);
printArray(currentArray);

int sum = getOddArrayElement(currentArray);
Console.WriteLine(sum);
