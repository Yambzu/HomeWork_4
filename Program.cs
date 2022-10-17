// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int ToDegree(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

Console.Write("Input number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = ToDegree(numberA, numberB);
Console.WriteLine($"{numberA} in degrees {numberB} = {result}.");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumber( int n)
{
    int sum = 0;
    for(int i = 1; n > 0; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumNumber(num);
Console.WriteLine($"Sum number {num} = {result}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] result = CreateArray(num);
Console.WriteLine(String.Join(", ", result));
*/