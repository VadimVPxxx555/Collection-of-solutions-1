// Задача 63. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 - > "1, 2, 3, 4, 5"
// N = 6 - > "1, 2, 3, 4, 5, 6"

void NumberPlus(int count)
{
    int num = 1;
    if(num < count)
    {
      NumberPlus(count);
      num++;
      Console.WriteLine(num);
    }
}

int EnterNumber(string message)  //message - сообщение
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = EnterNumber("введите значение ");

NumberPlus(number);

// void NumberPlus(int count)
// {
//     int num = 1;
//     if(num < count)
//     {
//       Console.WriteLine(num);
//       num++;
//     }
//     NumberPlus(count);
// }