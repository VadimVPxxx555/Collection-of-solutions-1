// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элемнгты каждой строки 
// двумерного массива.

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

int[,] OrderingArray(int[,] arr)
{
    int min = 0;
    int k = 0;
    int counti = 0;
    int countj = 0;
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           min = arr[i,j];
           k = j;
           while(k < arr.GetLength(1))
            {
                if(arr[i,k] < min)
                {
                  min = arr[i,k];
                  counti = i;
                  countj = k;
                }
            k++;
            }
           temp = arr[i,j];
           arr[i,j] = min; 
           arr[counti,countj] = temp;
        
        }       
    }
    System.Console.Write(min);
    System.Console.WriteLine();
    System.Console.Write(arr[counti,countj]);
    System.Console.WriteLine();
    return arr;
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

ShowArray(matrix);

System.Console.WriteLine();

// упорядочить по убыванию массив
int[,] arr = OrderingArray(matrix);

// вывести массив в консоль
ShowArray(arr);