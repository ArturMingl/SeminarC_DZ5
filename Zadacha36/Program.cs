//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void mass(int[] array) //создаёт массив с рандомными значениями
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next();
    }
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

int[] array = new int[size];

mass(array);

Console.WriteLine($"массив - {string.Join(",", array)}");
Console.WriteLine($"сумма чисел с нечётными индексами - {sum_res(array)}");