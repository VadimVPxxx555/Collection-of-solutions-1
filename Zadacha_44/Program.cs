// Не используя рекурсию выведите число фибоначи до N

Console.Clear();

int DataEnter(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Fibonachi(int n)
{
    int a = 0;
    int b = 1;
    int f = 0;
    Console.Write("0 1 ");
    for (int i = 2; i < n; i++)
    {
        f = a+b;  // 2 + 3
        Console.Write(f + " ");
        a = b;
        b = f;
    }
}

int n = DataEnter("Введите число ");
Fibonachi(n);