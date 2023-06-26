Console.Write("Please, enter first integer number: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Please, enter second integer number: ");
int secondNum = int.Parse(Console.ReadLine());

if ((firstNum == secondNum*secondNum) || (secondNum == firstNum*firstNum)){
    Console.WriteLine("yes");
}else{
  Console.WriteLine("no"); 
}