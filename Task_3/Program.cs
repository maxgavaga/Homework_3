// Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int length = cube.Length;
  for (int counter = 1; counter < length; counter++)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
  }
}

void PrintArray(int[] coll)
{
  int count = coll.Length;
  for (int index = 1; index < count; index++)
  {
    Console.Write(coll[index]+ " ");
  }
} 

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);