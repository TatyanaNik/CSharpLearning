//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
int[] numbers = new int[3];

//init array
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter a number: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

//max finder
int max = numbers[0];

for (int i = 1; i < 3; i++)
{
    if (numbers[i] > max){
        max = numbers[i];
    }
}

//output
Console.WriteLine($"Max number = {max}");
