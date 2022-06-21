
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine($" {number} Ваше число - палиндром.");
  }
  else Console.WriteLine($"{number} Ваше число не является палиндромом.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Неверное количество знаков. Попробуйте еще раз!");