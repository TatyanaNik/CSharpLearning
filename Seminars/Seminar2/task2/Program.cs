Console.Write("Please, enter first integer number: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Please, enter second integer number: ");
int secondNum = int.Parse(Console.ReadLine());

int mod = firstNum%secondNum;

if (mod == 0){
    Console.WriteLine("yes"); 
}else{
  Console.WriteLine($"no, mod = {mod}");  
}
