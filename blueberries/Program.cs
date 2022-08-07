/* Сбор черники

У каждого куста есть только два соседних
N (3 ≤ N ≤ 1000) – количество кустов черники.
на i-ом кусте выросло ai ягод
кусты высажены только по окружности.
Вторая строка содержит N целых положительных 
чисел a1, a2, ..., aN – число ягод черники, 
растущее на соответствующем кусте. Все ai не превосходят 1000. */

Console.WriteLine("Введите кол-во кустов черники. Не меньше 3, не больше 1000: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int sum1 = 0;
int sum2 = 0;
int temp1 = 0;
int temp2 = 0;
while (n < 3 || n > 1000)
    {
        Console.WriteLine("Кол-во кустов черники должно быть не меньше 3, не больше 1000: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число ягод на кусте: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    sum = temp1 + temp2 + array[i];
    temp2 = temp1;
    temp1 = array[i];
    if (sum > sum1)
        sum1 = sum;
    else
        sum = sum1;
    if (i == n - 1)
        sum2 = array[0] + array[1] + array[n - 1];
        if (array[1] < array[n - 2])
            sum2 = array[0] + array[n - 2] + array[n - 1];
    if (sum2 > sum)
        sum = sum2;

}    
Console.WriteLine("[" + string.Join(", ", array) + "] -> " + sum + " ягод");
