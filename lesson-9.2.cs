// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m = InputNumber("Введите M:");
int n = InputNumber("Введите N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");


int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}

int InputNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}