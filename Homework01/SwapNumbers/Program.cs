Console.WriteLine("Enter the first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

double temporary = firstNumber;
firstNumber = secondNumber;
secondNumber = temporary;

Console.WriteLine("After swapping: ");
Console.WriteLine("First number: " + firstNumber);
Console.WriteLine("Second number: " + secondNumber);
