// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Метод определения чисел больше нуля
int GetCountPositiveNum(int number)
{
    int[] NumArray = new int [number];
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        NumArray[i] = int.Parse(Console.ReadLine()); 
        if (NumArray[i] > 0) count = count + 1;
    }
    return count;
}

// Определяем входные данные
Console.Write("Укажите количество заданных чисел: ");
int Num = int.Parse(Console.ReadLine());

int CountPositiveNum = GetCountPositiveNum(Num);
Console.WriteLine($"Кол-во введенныx положительных чисел = {CountPositiveNum}");
