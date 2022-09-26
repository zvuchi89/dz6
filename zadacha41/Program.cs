// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите количество чисел:");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];


void InputArray(int m)

{
for (int i = 0; i < m; i++)
  {
    Console.Write($"введите число {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[]array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}
InputArray(m);
Console.Write( "Количество чисел больше нуля:");
Console.WriteLine("[" + string.Join(",", Comparison(array))+"]");
