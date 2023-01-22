// задача 46. Задайте двумерный массив, размером m x n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Clear();

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

int EnterNumber(string message)  //message - сообщение
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// получить от пользователя M и N 
int m = EnterNumber("введите значение m ");
int n = EnterNumber("введите значение n ");

// создать двумерный массив и заполнить 
int[,] matrix = CreateRandomArray(m, n, 1, 9); // Создать случайный массив

// вывести массив в консоль
ShowArray(matrix); // Показать массив