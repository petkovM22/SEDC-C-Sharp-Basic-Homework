string[] studentsG1 = new string[] { "Ana", "Martin", "Marko", "Stefan", "Nikola" };
string[] studentsG2 = new string[] { "Ilija", "Toni", "Dragan", "Lazar", "Ivan" };

Console.WriteLine("Enter student group: ");
int groupNumber = Convert.ToInt32(Console.ReadLine());


if (groupNumber == 1)
{
    Console.WriteLine("Students in G1 are :");
    foreach(string student in studentsG1)
        Console.WriteLine(student);
}
else  if (groupNumber == 2)
{
    Console.WriteLine("Students in G2 are :");
    foreach (string student in studentsG2)
        Console.WriteLine(student);
}
else
{
        Console.WriteLine("Invalid input");
}