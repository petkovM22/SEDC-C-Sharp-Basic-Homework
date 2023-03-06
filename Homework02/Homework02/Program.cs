int[] numbers = new int[] { 4, 7, 10, 15, 12, 19 };
int sum = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}

Console.WriteLine(sum);