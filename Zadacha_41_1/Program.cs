// Пользователь вводит с клавиатуры М чисел
// Посчитайте, сколько чисел больше 0 ввел пользователь.

string DataEnter(string str)
{
    Console.Write(str);
    string number = Console.ReadLine();
    return number;
}

void Main(int[] args) 
{
    string s = "128759746539867648";
    int[] arr = s.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
    Console.WriteLine(string.Join("-", arr));
    Console.ReadLine();
}

int[] ArrayData(int arrNumber, int leftRange, int rightRange)
{
   Random rand = new Random();
   int[] array = new int[arrNumber];
   int i = 0;
  for(i = 0; i < array.Length; i++)
  {
    array[i] = rand.Next(leftRange, rightRange + 1);
  } 
  return array;
}


string m =  DataEnter("Введите число ");
Console.Write(m);
int[] arr = ArrayData(5, 1, 10);
Main(arr);




// int n = int.Parse(m);
// Console.Write(m);