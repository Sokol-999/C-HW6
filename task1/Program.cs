// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0
//  ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
System.Console.WriteLine("Write numbers with 'space': ");
// int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
var arr = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) count++;
}
System.Console.WriteLine(count);