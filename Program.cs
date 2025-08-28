

class Program
{
  static void Main(string[] args)
  {

    IShape circle = new Circle(5.0);
    IShape rectangle = new Rectangle(7.0, 5.0);
    IShape triangle = new Triangle(3, 4, 5);
    IShape square = new Square(4.0);


    Console.WriteLine($"Circle: Area = {circle.Area()}, Perimeter = {circle.Perimeter()}");
    Console.WriteLine($"Rectangle: Area = {rectangle.Area()}, Perimeter = {rectangle.Perimeter()}");
    Console.WriteLine($"Triangle: Area = {triangle.Area()}, Perimeter = {triangle.Perimeter()}");
    Console.WriteLine($"Square: Area = {square.Area()}, Perimeter = {square.Perimeter()}");
  }
}


