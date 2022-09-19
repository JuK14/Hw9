// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Введите целое положительное число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ещё одно целое положительное число, больше первого");
int n = int.Parse(Console.ReadLine());
while (m < 0 || n < 0)
{
    if (m < 0)
    {
        Console.Write("Вы ввели отрицательное первое число. Введите число заново : ");
        m = int.Parse(Console.ReadLine());
    }
    if (n < 0)
    {
        Console.Write("Вы ввели отрицательное второе число. Введите число заново : ");
        n = int.Parse(Console.ReadLine());
    }
}
while (m >= n)
{
    Console.Write("Вы ввели второе число меньше чем первое. ");
    Console.Write("Введите второе число, больше первого: ");
    n = int.Parse(Console.ReadLine());    
}

void NaturalNumber(int arg1, int arg2)
{
    if (arg1 == arg2)
    {
        Console.WriteLine($" {arg1}");
        return;
    }
    if (arg1 < arg2)
    {
        Console.Write($" {arg1},");
        NaturalNumber(arg1 + 1, arg2);
    }
}








// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
Console.WriteLine("Введите целое положительное число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ещё одно целое положительное число, больше первого");
int n = int.Parse(Console.ReadLine());
while (m < 0 || n < 0)
{
    if (m < 0)
    {
        Console.Write("Вы ввели отрицательное первое число. Введите число заново : ");
        m = int.Parse(Console.ReadLine());
    }
    if (n < 0)
    {
        Console.Write("Вы ввели отрицательное второе число. Введите число заново : ");
        n = int.Parse(Console.ReadLine());
    }
}
while (m >= n)
{
    Console.Write("Вы ввели второе число меньше чем первое. ");
    Console.Write("Введите второе число, больше первого: ");
    n = int.Parse(Console.ReadLine());    
}
void SumNumber(int arg1, int arg2, int sum)
{
    if (arg1 == arg2)
    {
        sum += arg1;
        Console.WriteLine($" {sum}");
        return;
    }
    if (arg1 < arg2)
    {
        sum += arg1;
        SumNumber(arg1 + 1, arg2, sum);
    }
}







// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        n = n + 1;
        return n;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.Write("Введите положительное число m А(m,n): ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите положительное число n А(m,n): ");
int numberN = int.Parse(Console.ReadLine());

while (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Вы ввели отрицательное число.");
    Console.Write("Введите значение m в функции Аккермана А(m,n): ");
    numberM = int.Parse(Console.ReadLine());
    Console.Write("Введите значение n в функции Аккермана А(m,n): ");
    numberN = int.Parse(Console.ReadLine());
}

int resul = Akkerman(numberM, numberN);
Console.WriteLine($"Функция Аккермана при А({numberM},{numberN}) = {resul}");