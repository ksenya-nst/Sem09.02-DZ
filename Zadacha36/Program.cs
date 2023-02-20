// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

 int Sum(int[] array)
{
    int result = 0;
    for(int i = 1; i < array.Length; i = i + 2)
    {
        result += array[i];
    }
    return result;
} 

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] arr = GenerateArray(10, -100, 100); 
PrintArray(arr);                          
System.Console.WriteLine($"Сумма нечетных элементов равна {Sum(arr)}"); 