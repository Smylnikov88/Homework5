// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length=int.Parse(ReadLine()!);
Write("Введите минимальное  значение массива: ");
int min=int.Parse(ReadLine()!);
Write("Введите максимальное  значение массива: ");
int max=int.Parse(ReadLine()!);
int[] Array= GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]");
FindEven(Array);

int[] GetArray(int size, int minValue, int maxValue)
{
  Random rnd= new Random();
  int[] result= new int[size];
  for(int i= 0; i< result.Length; i++)
  {
    result[i] = rnd.Next(minValue, maxValue+ 1);
  }
  return result;
}

void FindEven(int[] MyArray)
{
 int even=0;
 for(int i= 1; i< MyArray.Length; i+=2)
 {
  
      even=even+MyArray[i] ;
 }
 

 WriteLine($"Сумма элементов на нечетных позициях: {even}");
}