// Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
double a;
double b;
double c;
double max;

a = 4;
b = 2;
c = 3;
max = a;

if (b>max) max = b;
if (c>max) max = c;

Console.Write("max = ");
Console.Write(max);