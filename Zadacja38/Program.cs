//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void CreateRandomArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * 10000;
}

void PrintArray(double[] array)
{
    foreach (double el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void MinMaxDiff(double[] array)
{
    int index = 0;
    double max = array[index];
    double min = array[index];
    for (index = 0; index < array.Length; index++)
    {
        if (array[index] > max) max = array[index];
        else if (array[index] < min) min = array[index];
    }
    double diff = max - min;
    Console.WriteLine($"Разница - {diff}");
}


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
CreateRandomArray(array);
PrintArray(array);
MinMaxDiff(array);