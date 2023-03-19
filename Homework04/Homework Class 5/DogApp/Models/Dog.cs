﻿
namespace DogApp.Models
{
    public class Dog
    {
        public string Name { get; set; }
        
        public string Breed { get; set; }

        public string Color { get; set; }


        public void Eat()
        {
            Console.WriteLine("The dog is now eating");
        }

        public void Play()
        {
            Console.WriteLine("The dog is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine("Dog is now chasing its tail");
        }
    }
}
