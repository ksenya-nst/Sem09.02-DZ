// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); 
    }
    return array;
}

int GetResult(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i = i+2) 
    {
        if(array[i] >= 100 && array[i] <= 999 && array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] arr = GenerateArray(10, 100, 1000); 
PrintArray(arr);                          
System.Console.WriteLine(GetResult(arr)); 