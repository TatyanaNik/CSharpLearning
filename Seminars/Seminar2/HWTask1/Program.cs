// S2HWT1
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//author: NikitinaT

Console.Write("Введите трехзначное число: ");
int Num = int.Parse(Console.ReadLine());

while ( Math.Abs(Num) > 999 || Math.Abs(Num) < 100)  {
    Console.Write("Число не является трехзначным. Попробуйте ввести еще раз: ");
    Num = int.Parse(Console.ReadLine());
} 

int SecondDigit = Math.Abs((Num/10)%10);
Console.WriteLine($"Second digit = {SecondDigit}");
