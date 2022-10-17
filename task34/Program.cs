/*

Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

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

int countElementsInArray(int[] incomingArray)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i] % 2 == 0)
        {
            count++;
        } 
    }
    return count;
} 

int[] currentArray = getRandomArray(9, 99,999);
printArray(currentArray);

int count = countElementsInArray(currentArray);
Console.WriteLine(count);