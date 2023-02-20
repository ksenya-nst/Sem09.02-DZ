// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



double[] GenerateArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    var rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); 
    }
    return array;
}

double max (double[] array)
{
    double result1 = 0;
    for(int i = 0; i < array.Length; i = i+1) 
    {
        if(array[i] > result1)
        {
            result1 = array[i];
        }
    }
    return result1;
}
    
   double min (double[] array)
{
    double result2 = 0;
    for(int i = 0; i < array.Length; i = i+1) 
    {
        if(array[i] < result2)
        {
            result2 = array[i];
        }
    }
    return result2;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double[] arr = GenerateArray(5, -10, 20); 
PrintArray(arr);                          
System.Console.WriteLine($"Разница между максимальным и минимальным элементом равна {max(arr) - min(arr)}"); 