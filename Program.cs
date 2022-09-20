// Напишите программу, которая 
//принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int insertThreedigitnumber()
{
    Console.WriteLine("Введите трехзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Seconddigit(int number)
{
    int dec = (number % 100)/10;
        return dec;
}
int a = Seconddigit(insertThreedigitnumber());
Console.WriteLine(a);