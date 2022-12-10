//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next();
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

int sum_res(int[] array) //Суммирует все значения на нечётных позициях
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int odd_index = i % 2;
        if (odd_index != 0) sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);
PrintArray(array);

Console.WriteLine($"сумма чисел с нечётными индексами - {sum_res(array)}");