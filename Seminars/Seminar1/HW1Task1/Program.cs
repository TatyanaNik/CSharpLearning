//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Write("Please, enter first integer number: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Please, enter second integer number: ");
int secondNum = int.Parse(Console.ReadLine());

if (firstNum > secondNum){
   Console.WriteLine($"{firstNum} bigger then {secondNum}"); 
}
else if (firstNum < secondNum){
   Console.WriteLine($"{firstNum} smaller then {secondNum}"); 
}
else{
     Console.WriteLine("Numbers are equal");
}
