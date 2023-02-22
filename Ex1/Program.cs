/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/

Console.WriteLine("Введите первое число");
string number1Str = Console.ReadLine();
Console.WriteLine("Введите второе число");
string number2Str = Console.ReadLine();

int number1 = Convert.ToInt32(number1Str);
int number2 = Convert.ToInt32(number2Str);

if(number2 * number2 == number1) 
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
