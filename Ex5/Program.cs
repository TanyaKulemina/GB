/***Задача 2:** Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7

a = 2 b = 10 -> max = 10

a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Напишите первое число");
string number1str = Console.ReadLine();
int number1 = Convert.ToInt32(number1str);

Console.WriteLine("Напишите второе число");
string number2str = Console.ReadLine();
int number2 = Convert.ToInt32(number2str);

if (number1 > number2)
{
    Console.WriteLine($"max = {number1}");
}
else if (number2 >= number1)
{
    Console.WriteLine($"max = {number2}");
}