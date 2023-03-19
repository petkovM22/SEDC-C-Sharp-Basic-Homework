Console.WriteLine("Enter your birthday (dd/mm/yyyy): ");
DateTime birthday = DateTime.Parse(Console.ReadLine());

int age = BirthdayCalculator(birthday);

Console.WriteLine($"Your age is {age}");


int BirthdayCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;

    int age = today.Year - birthday.Year;

    if (birthday > today.AddYears(-age))
    {
        age--;
    }
    return age;
}