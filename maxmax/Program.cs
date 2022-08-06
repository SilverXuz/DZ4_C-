// Расстояние между локальными максимумами


Console.Write("Введите число от 1 до 100: ");
int n = Convert.ToInt32(Console.ReadLine()); // первое число
int n_first = n; // первая ячейка темп для первого числа
int n_second = 0; // вторая ячейка тем для второго числа
int temp_i_first = 0; // темп для первого индекса локального максимума
int temp_i_second = 0; // темп для второго индекса локального максимума
int max = 0; // искомый результат
int max_count = 0; // кол-во найденных максимумов
for (int i = 0; n != 0; i++)
    {
        Console.Write("Введите число от 0 до 100.(Ноль завершит ввод): "); 
        n = Convert.ToInt32(Console.ReadLine()); // второе число

        if (n_second > n_first && n < n_second)
            {
                temp_i_second = temp_i_first;
                temp_i_first = i;
                n_first = n_second;
                n_second = n;
                max_count++;
            }
            else
                {
                    n_first = n_second; 
                    n_second = n;
                }
        if (temp_i_second > temp_i_first)
            max = temp_i_second - temp_i_first;
        else
            max = temp_i_first - temp_i_second;
        if (max_count < 2)
            max = 0;
    }

Console.WriteLine("Расстояние: " + max);
