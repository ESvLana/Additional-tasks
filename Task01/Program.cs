// Сгенерировать массив из N целых чисел от 1 до 100.. 
// Выведите на экран элементы, кратные трём и пяти, но не кратные семи.

int[] CreateRandomArray(int size)  // Произвольный массив
{
    int[] Array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        Array[i] = rnd.Next(1, 100);
    }
    return Array;
}

void CheckIfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 3 == 0 && array[i] % 5 == 0 && array[i] % 7 != 0)
        {
            Console.Write($"{array[i]} ");
            count += 1;
        }
    }
    if (count == 0)
    {
        Console.Write("Элементы, кратные трём и пяти, но не кратные семи - отсутствуют");
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int N = Int32.Parse(Console.ReadLine()!);

int[] Array = CreateRandomArray(N);
Console.WriteLine("Массив:");
PrintArray(Array);

CheckIfEven(Array);