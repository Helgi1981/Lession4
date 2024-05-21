// Задача №1

// • Создать двумерный массив с размерами 3 x 5, состоящий из целых чисел
// • Вывести его элементы на экран

// Этапы создания массива:
// 1. Указание типа данных
// 2. Указание имени массива
// 3. Выделение памяти под элементы

int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // Random rnd = new Random(); генератор случайных чисел нужно выводить за 
            // пределы цикла, т.к. он будет запускаться каждый раз с новым оборотом цикла и
            // тормозить работу программы
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);