// Задача 41: Пользователь вводит с клавиатуры
// М чисел. Посчитайте, сколько чисел больше 0
// ввел пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int ArrayElementCount()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int B = ArrayElementCount();
Console.WriteLine($"Кол-во чисел больше нуля: {B}");

