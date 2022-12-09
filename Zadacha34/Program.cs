//адайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void mass(int[] array) //создаёт массив с рандомными значениями
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
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

int[] array = new int[size];

mass(array);

Console.WriteLine($"массив - {string.Join(",", array)}");
Console.WriteLine($"колличесво чётных чисел - {count_res(array)}");