Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int sum = sumOfDigits(number);
Console.WriteLine("The sum of the digits is: " + sum);


int sumOfDigits(int number)
{
    if (number == 0)
    {
        return 0;
    }
    else
    {
        return (number % 10) + sumOfDigits(number / 10);
    }
}