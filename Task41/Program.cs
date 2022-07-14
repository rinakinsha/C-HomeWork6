int[] ConversionToArray(int size)
{
    while (size <= 0)
    {
        Console.Write("А нееет, так не пойдет, введите другое число: ");
        size = Convert.ToInt32(Console.ReadLine());
    }

    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число для " + i + "-го элемента массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

int PositiveNumbers(int[] array)
{
    int numbers = 0;
    for (int j = 0; j < array.Length; j++)
        if (array[j] > 0) numbers++;

    return numbers;
}

Console.Write("Введите размерность массива (определяйтесь с умом, ведь вводить придется ручками): ");
int number = Convert.ToInt32(Console.ReadLine());

int[] newarray = ConversionToArray(number);

Console.Write("Ваш массив: ");
ShowArray(newarray);

Console.WriteLine("Количество положительных чисел в массиве: " + PositiveNumbers(newarray));
