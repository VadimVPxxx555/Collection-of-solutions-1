// Пользователь вводит с клавиатуры М чисел
// Посчитайте, сколько чисел больше 0 ввел пользователь.

string DataEnter(string str)
{
    Console.Write(str);
    string number = Console.ReadLine();
    return number;
}



string m =  DataEnter("Введите число ");
Console.Write(m);

// int[] arr = m.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
//             Console.WriteLine(string.Join("-", arr));
//             Console.ReadLine();


// int n = int.Parse(m);
// Console.Write(m);