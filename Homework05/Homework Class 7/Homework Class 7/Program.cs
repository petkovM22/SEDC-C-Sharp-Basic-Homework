using Homework_Class_7.Models;

int[] position = { 0, 0 };

Shape shape = new Shape("Shape", "Black", position);
shape.GetArea();
shape.GetPerimeter();
shape.Move();

Rectangle rectangle = new Rectangle("TestRectangle", "Black", position, 10, 15);
rectangle.GetArea();
rectangle.GetPerimeter();
rectangle.Move();

Circle circle = new Circle("TestCircle", "Black", position, 10);
circle.GetArea();
circle.GetPerimeter();
circle.Move();