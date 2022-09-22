// Напишите программу, которая принимает на вход два числа и проверяет, является ли
//одно число квадратом другого.
void square()
{
    Console.WriteLine("Введите 2 числа:");
    int firstnumber = Convert.ToInt32(Console.ReadLine());
    int secondnumber = Convert.ToInt32(Console.ReadLine());
    if (firstnumber/secondnumber==secondnumber)
    {
        Console.WriteLine("Первое число явлется квадратом второго");
    }
    else if (secondnumber/firstnumber==firstnumber)
    {
        Console.WriteLine("Второе число является квадратом первого");
    }
    else
    {
        Console.WriteLine("Ни одно из чисел не является квадратом другого");
    }
}
square();