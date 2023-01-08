// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
Console.Clear();

Random rand = new Random();
// Метод создает массив из случайных целых чисел (+ и -), и добавляет 
// десятичное значение того же знака, что и целое число.
double[] ArrayData(int arrNumber, int leftRange, int rightRange)
{
   double[] array = new double[arrNumber];
   int i = 0;
  for(i = 0; i < array.Length; i++)
  {
    double r = Math.Round(rand.NextDouble(), 3);
    Console.WriteLine(r);

    array[i] = rand.Next(leftRange, rightRange + 1);
    Console.WriteLine(array[i]);

    double array2 = array[i];
    double modul2 = Math.Abs(array2);
    double modul = array[i] / modul2;
    Console.WriteLine(modul);
    
    r = modul * r;
    array[i] = array[i] + r;
  } 
  return array;
}

void DifferenceNumberArray(double[] arrayEN)
{
    double max = arrayEN[0];
    double min = arrayEN[0];
    for(int i = 0; i < arrayEN.Length; i++)
    {
        if(arrayEN[i] > max)  
        {
           max = arrayEN[i]; 
        }

        if(arrayEN[i] < min)  
        {
           min = arrayEN[i]; 
        }
    }
    
    Console.Write($"max -> {max} ");
    Console.WriteLine($"min -> {min} ");
    double difference = max - min;
    Console.Write($"разницу между max и min элементом массива -> {difference} ");
}

int DataEnyer(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int arrNumber = DataEnyer("Введите размер массива ");
int leftRange = DataEnyer("Введите min диапазон массива ");
int rightRange = DataEnyer("Введите max диапазон массива ");

double[] array = ArrayData(arrNumber, leftRange, rightRange);
Console.WriteLine('[' + string.Join("; ", array) + ']');
DifferenceNumberArray(array);