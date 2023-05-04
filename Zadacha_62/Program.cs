// Напишите программу, которая заполнит спирально массив 4 на 4.

// 01(0,0) 02(0,1) 03(0,2) 04(0,3)   
// 12(1,0) 13(1,1) 14(1,2) 05(1,3)
// 11(2,0) 16(2,1) 15(2,2) 06(2,3)
// 10(3,0) 09(3,1) 08(3,2) 07(3,3)

int[,] CreateRandomArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int i = 0;
    int j = 0;
    int a = i;
    int b = j;
    int sum = 0;

    

    for (i = 0; i < 4; i++) // 1
    {
        for (j = 0; j < 4; j++)
        {
            a = i;
            b = j;
            sum += 1;
            array[i,j] = sum;
        }
    }
    for (j = 3; j < columns; j++) // 2
    {
        for (i = 1; i < rows; i++)
        {
            a = i;
            b = j;
            sum += 1;
            array[a,b] = sum;
        }
    }
    for (i = 3; i < rows; i++) // 3
    {
        for (j = 2; j >= 0; j--)
        {
            a = i;
            b = j;
            sum += 1;
            array[i,j] = sum;
        }
    }
    return array;
}

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

// создать двумерный массив
int[,] matrix = CreateRandomArray(4, 4);

ShowArray(matrix);




//  for (i = 0; i < rows; i++)
//     {
//         for (j = 0; j < columns; j++)
//         {
//             array[a,b] = array[a,b] + 1;
//         }
//         a = j; b = i;
//     }
//     return array;




//     for (i = 0; i < rows; i++)
//     {
//         for (j = 0; j < columns; j++)
//         {
//             array[a,b] = array[a,b] + 1;
//         }
//         for (int c = j; c < columns; c++)
//         {
//             for (int d = i; d < rows; d++)
//             {
//                a = d; b = c;
//                array[a,b] = array[a,b] + 1;
//             }
//         }
//         for (i = 0; i < rows; i--)
//     }
//     return array;

// for (i = 0; i < rows; i++)
//     {
//         for (j = 0; j < columns; j++)
//         {
//             sum += 1;
//             array[a,b] = sum;
//         }
//         for (int d = i + 1; d < rows; d++)
//         {
//             a = d; 
//             sum += 1;
//             array[a,b] = sum;
//         }
//         for (int c = columns - j; c > 0; c--)
//         {
//             b = c; 
//             sum += 1;
//             array[a,b] = sum;
//         }
//         for (int e = rows - 1; e > 0; e--)
//         {
//             a = e; 
//             sum += 1;
//             array[a,b] = sum;
//         }

//     }
//     return array;