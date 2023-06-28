// S2HWT2
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//author: NikitinaT

Console.Write("Please, enter integer number in range from 1 to 7: ");
int Num = int.Parse(Console.ReadLine());


if (Num == 6 || Num == 7){
    Console.WriteLine($"Day {Num} is day off");
}else if (Num < 1 || Num > 7){
    Console.WriteLine("incorrect data");
}else{
    Console.WriteLine($"Day {Num} is weekday");
}