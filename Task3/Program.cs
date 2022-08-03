// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// 1 вариант с обозначенным массивом заранее
// int[] array = new int[8] { 1, 2, 5, 7, 19, 6, 1, 33};
// Console.WriteLine("[" + string.Join(", ", array) + "]");


//2 вариант с вводом массива в ручную
int[] array = new int[8];
int i = 0;
while (i < 8)
{
    Console.Write("Введите в общей сложности восемь чисел: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
