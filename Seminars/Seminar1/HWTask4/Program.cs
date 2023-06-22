// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int num;
do{
    Console.Write("Enter a non-negative number: ");
    num = int.Parse(Console.ReadLine());
}
while (num < 0);

if (num < 2) {Console.WriteLine("There are no valid numbers");}

for (int i = 2; i <= num; i=i+2)
{
    Console.Write($"{i} ");
}
Console.WriteLine();