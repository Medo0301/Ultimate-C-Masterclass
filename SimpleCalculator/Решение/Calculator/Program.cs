// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello");
Console.WriteLine("Input the first number: ");
string firstInput = Console.ReadLine();
int firstNum = int.Parse(firstInput);

Console.WriteLine("Input the second number: ");
string secondInput = Console.ReadLine();
int secondNum = int.Parse(secondInput);

int result;

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userChoice = Console.ReadLine();
if(userChoice == "A" || userChoice == "a")
{
    result = firstNum + secondNum;
    Console.WriteLine(
        firstNum + " + " + secondNum +
        " = " + result);
}
else if (userChoice == "S" || userChoice == "s")
{
    result = firstNum - secondNum;
    Console.WriteLine(
        firstNum + " - " + secondNum +
        " = " + result);
}
else if (userChoice == "M" || userChoice == "m")
{
    result = firstNum * secondNum;
    Console.WriteLine(
        firstNum + " * " + secondNum +
        " = " + result);
}
else
{
    Console.WriteLine("Incorect option");
}

Console.WriteLine("Press any key to close");
Console.ReadKey();


