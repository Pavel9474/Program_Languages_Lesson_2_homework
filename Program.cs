// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int Digit(int number)
{
    int digit = number.ToString()[2]- '0';
    return digit;
}
if (number>=100)
{
    int a = Digit(number);
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("третьей цифры нет");
}