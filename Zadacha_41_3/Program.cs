// Пользователь вводит с клавиатуры М чисел
// Посчитайте, сколько чисел больше 0 ввел пользователь.

int[] ArrayData() // симуляция ввода пользователем
{
   int leftRange = -100;
   int rightRange = 100;
   int arrNumber = new Random().Next(1,20);
   Random rand = new Random();
   int[] array = new int[arrNumber];
   int i = 0;
  for(i = 0; i < array.Length; i++)
  {
    array[i] = rand.Next(leftRange, rightRange + 1);
  } 
  return array;
}


int SumPozitiv (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum++;
        }
        
    }
    return sum;
}


int[] arr = ArrayData();
Console.WriteLine(string.Join(", ", arr));

int sum = SumPozitiv(arr);
Console.WriteLine("чисел больше 0 -> " + sum);