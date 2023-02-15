// Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

int Prompt(string message)
{
    Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int a = Prompt ("Ведите 1 число");
int b = Prompt ("Ведите 2 число");
int c = Prompt ("Ведите 3 число");

int Max = a;
if (b > Max) Max = b;
if (c > Max) Max = c; 
Console.WriteLine(Max);