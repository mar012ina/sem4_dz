// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B (Math.Pow НЕ использовать)
// 3, 5 -> 243 (3⁵)
// 0, 0 - >1
// 2, 4 -> 16

int Exponentiation(int a, int b)
{
    int count = 1;
    int res = 1;
    while (count <= b)
    {
        if (b == 0) res = 1;
        else
        {
            res = res * a;
            count++;
        }
    }
    return res;
}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == 0 & num2 == 0)
{
    Console.Write("Серьезно? 0 в степени 0? Меняй числа)");
}
else
{
    Console.Write($"Число {num1} в степени {num2} равно {Exponentiation(num1, num2)}");
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int n)
{
    int sum = 0;
    for (int i = 0; i <= n; i++)
    {
        sum = sum + (n % 10);
        n = n / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0) Console.WriteLine("Лучше введи положительно число больше 0)");
else {
Console.WriteLine($"Сумма цифр числа {num} равна {SumOfDigits(num)}");
}


// Задача 29: Напишите программу, которая создает массив заданного пользователем размера, 
// заполняет массив элементами от 1 до 99 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("\b]");
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num <= 0 ) Console.Write("Введите другое число");
else PrintArray(CreateArray(num));