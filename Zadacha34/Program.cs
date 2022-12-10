//адайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100,1000);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

int count_res(int[] array) //считает кол-во чётных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int remains = array[i] % 2;
        if (remains == 0) count++;
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);
PrintArray(array);
count_res(array);
Console.WriteLine($"колличесво чётных чисел - {count_res(array)}");