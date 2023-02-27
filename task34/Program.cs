// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
//  числами. Напишите программу, которая покажет количество
//  чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

void PrintArray(int[] inArray)
{
for (int i = 0; i < inArray.Length; i++)
{
Console.Write($"{inArray[i]} ");
}
}

int[] GetSumEven(int[] inArray)
{

int[] result = new int [inArray.Length ];
for (int i = 0; i < inArray.Length / 2; i++)
{
    
  if(inArray [i] % 2 == 0)
result= ;
}
 return result;
}

int[] array = GetArray(10, 100, 999);
PrintArray(array);
 System.Console.WriteLine();
 int[] resultArr = GetSumEven(array);
 PrintArray(resultArr);

// for (int x = 0; x < numbers.Length; x++)
// {
// if (numbers[x] % 2 == 0)
// count++;
// }
// Console.WriteLine($"из {numbers.Length} чисел, {count} четных");



