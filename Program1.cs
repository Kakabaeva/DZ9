// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.WriteLine("Введите первое натуральное число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число больше первого ");
int n = Convert.ToInt32(Console.ReadLine());
ShowAllNumbersToN(m);

void ShowAllNumbersToN(int m)
{

    if (m%2==0) 
    { 
        if (n==m | n==(m+1)) Console.WriteLine($" {m} ");
        else
        {
            Console.Write($" {m} ");
            ShowAllNumbersToN(m+2);
        }
    }
    if (m%2!=0) 
    {
        m=m+1;
        Console.Write($" {m} ");
            ShowAllNumbersToN(m+2);
            
    }


}
