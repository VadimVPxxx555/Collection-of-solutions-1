// Задача 63. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 - > "1, 2, 3, 4, 5"
// N = 6 - > "1, 2, 3, 4, 5, 6"

void NumberPlus(int count, int num)
{
   
   if(count <= num)
    {
      Console.WriteLine(count);
      count++;
      NumberPlus(count, num);
    }
}

int EnterNumber(string message)  //message - сообщение
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int count = EnterNumber("введите значение от ");
int num = EnterNumber("введите значение до ");

NumberPlus(count, num);

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