Console.WriteLine("Enter the first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the operation: ");
char operation = Convert.ToChar(Console.ReadLine());

double result = 0;

switch(operation)
{
    case '+': 
        result = firstNumber + secondNumber;
        break;
    case '-':
        result = firstNumber - secondNumber;
        break;
    case '*':
        result = firstNumber * secondNumber;
        break;
    case '/':
        result = firstNumber / secondNumber;
        break;
    default:
        Console.WriteLine("Enter a valid operation");
        break;
}

Console.WriteLine("The result is: " + result);
