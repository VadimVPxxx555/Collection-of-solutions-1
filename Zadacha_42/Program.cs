// N42. напишите программу, которая преобразовывает десятичное 
// число в двоичное.  

Console.Clear();

// int a1 = 2;
// int a2 = 0;
// while(a1 > 0)
// {
//     a2 = a1;
//     a2 = a2 % 2;
//     a1 = a1 / 2;
//     //Console.Write("a2 -> " + a2 + "; ");
//     Console.Write(a2);
    
// }

int DataEnter(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Правильное решение

void DuoNumber(int num)
{
    if(num <= 0)
    {              // Рекурсия
        return;   // После того, как метод вызвал себя последний раз,
                  // он начинает выводить значения в консоль
                  // с конца (цикла методов)
    }
    DuoNumber(num /2);
    Console.Write(num % 2);
}

int num1 = DataEnter("Введите число ");
DuoNumber(num1);
