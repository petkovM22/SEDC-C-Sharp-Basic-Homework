using DogApp.Models;

Console.WriteLine("Enter the dog's name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter the dog's breed: ");
string breed = Console.ReadLine();

Console.WriteLine("Enter the dog's color: ");
string color = Console.ReadLine();

Dog dog = new Dog {  Name = name, Breed = breed,Color = color };

Console.WriteLine("What's the dog doing?");
Console.WriteLine("1. Eat");
Console.WriteLine("2. Play");
Console.WriteLine("3. Chasing tail");

int option = int.Parse(Console.ReadLine());

switch (option)
{
    case 1:
        dog.Eat();
        break;
    case 2:
        dog.Play();
        break;
    case 3:
        dog.ChaseTail();
        break;
    default:
        Console.WriteLine("Invaild option!");
        break;
}