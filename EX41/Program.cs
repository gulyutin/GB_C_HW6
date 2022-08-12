// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите размер массива:\t");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива:\t");
int [] array = GetArray(size);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

int[] GetArray (int size)
{
    int [] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(Console.ReadLine());
    }    
    return result;
}


int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество чисел больше 0: {count}");