using System;

// Interface
interface IShape
{
    double Area();
    double Perimeter();
}

// Implementations
class Circle : IShape
{
    public double Radius { get; set; }
    public Circle(double radius) => Radius = radius;

    public double Area() => Math.PI * Radius * Radius;
    public double Perimeter() => 2 * Math.PI * Radius;
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width; Height = height;
    }

    public double Area() => Width * Height;
    public double Perimeter() => 2 * (Width + Height);
}

class Triangle : IShape
{
    public double A, B, C;
    public Triangle(double a, double b, double c)
    {
        A = a; B = b; C = c;
    }

    public double Area()
    {
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C)); // Heron’s formula
    }

    public double Perimeter() => A + B + C;
}


class Square : IShape 
{
    public double Side { get; set; }
    public Square(double side) => Side = side;

    public double Area() => Side * Side;
    public double Perimeter() => 4 * Side;  
}