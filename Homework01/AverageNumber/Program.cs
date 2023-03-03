Console.WriteLine("Enter first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter third number: ");
double thirdNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter fourth number: ");
double fourthNumber = Convert.ToDouble(Console.ReadLine());

double average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + ", " + fourthNumber + " is: " + average);