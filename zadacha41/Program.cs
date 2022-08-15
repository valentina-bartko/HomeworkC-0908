// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
// больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

// Пусть M будет случайно сгенерированным числом из диапазона от 4 до 9.

int amount = new Random().Next(4,10);
int[] array = new int[amount];

void FillArray(int x, int[] arr)
{
    for (int i = 0; i < x; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int PositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count +=1;
    }
    return count;
}

FillArray(amount, array);

Console.WriteLine($"Чисел больше нуля: {PositiveNumbers(array)} ");