// Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Weekend()
{
    Console.WriteLine("Введите число");
    int Day = Convert.ToInt32(Console.ReadLine());
    if (7>= Day & Day >=6)
    {
        Console.WriteLine("Выходной");  
    }
    else if (6 > Day & Day >= 1)
    {
        Console.WriteLine("Работать!"); 
    }
    else
    {
        Console.WriteLine("Введите число от 1 до 7");
    }
}
Weekend();