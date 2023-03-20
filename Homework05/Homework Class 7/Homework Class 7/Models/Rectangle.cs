
using System.Xml.Linq;

namespace Homework_Class_7.Models
{
    public class Rectangle : Shape
    {
        private int _sideA;

        private int _sideB;

 
        public Rectangle(string name, string color, int[] position, int firstSide, int secondSide) : base(name, color, position)
        {
            _sideA = firstSide;
            _sideB = secondSide;
        }

        public override void GetArea()
        {
            Console.WriteLine($"The area of the rectangle {Name} is: {_sideA * _sideB}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of the rectangle {Name} is: {(_sideA * 2) + (_sideB * 2)}");
        }
    }
}
