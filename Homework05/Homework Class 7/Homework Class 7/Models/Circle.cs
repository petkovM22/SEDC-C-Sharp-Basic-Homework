
namespace Homework_Class_7.Models
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle(string name, string color, int[] positon, int radius) : base(name, color, positon)
        {
            _radius = radius;
        }

        public override void GetArea()
        {
            Console.WriteLine($"The area of the circle {Name} is {Math.PI * _radius * _radius}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of the circle {Name} is {2 * Math.PI * _radius}");
        }
    }
}
