
namespace Homework_Class_7.Models
{
    public class Shape
    {
        private string _name;

        private string _color;

        public int[] Position { get; set; }

        public Shape(string name, string color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (string.IsNullOrEmpty(_name))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    Console.WriteLine($"The name is {_name}");
                }
            }
        }
        public string Color
        {
            get { return Color; }
            set
            {
                _color = value;
                if (string.IsNullOrEmpty(_color))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    Console.WriteLine($"The color is {_color}");
                }
            }
        }
        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area.");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"Moving the {Name}");
            Position[0] += 5;
            Position[1] += 5;
        }

    }
}
