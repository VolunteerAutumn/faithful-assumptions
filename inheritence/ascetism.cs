using System;
using System.Collections.Generic;

abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{GetType().Name} | Area: {GetArea():F2} | Perimeter: {GetPerimeter():F2}";
    }
}

abstract class Polygon : Shape
{
    private int sideLength;

    public int SideLength
    {
        get { return sideLength; }
        set
        {
            if (value < 0) throw new ArgumentException("Side length cannot be negative.");

            sideLength = value;
        }
    }

    private int numberOfSides;

    public int NumberOfSides
    {
        get { return numberOfSides; }
        protected set { numberOfSides = value; }
    }

    protected Polygon(int sideLength, int numberOfSides)
    {
        SideLength = sideLength;
        NumberOfSides = numberOfSides;
    }

    protected Polygon() : this(0, 0)
    {
    }
}

class Triangle : Polygon
{
    public Triangle(int sideLength) : base(sideLength, 3)
    {
    }

    public Triangle() : base()
    {
    }

    public override double GetArea()
    {
        return (Math.Sqrt(3) / 4) * SideLength * SideLength;
    }

    public override double GetPerimeter()
    {
        return SideLength * 3;
    }
}

class Square : Polygon
{
    public Square(int sideLength) : base(sideLength, 4)
    {
    }

    public Square() : base()
    {
    }

    public override double GetArea()
    {
        return SideLength * SideLength;
    }

    public override double GetPerimeter()
    {
        return SideLength * 4;
    }
}

class Rhombus : Polygon
{
    public Rhombus(int sideLength) : base(sideLength, 4)
    {
    }

    public Rhombus() : base()
    {
    }

    public override double GetArea()
    {
        return SideLength * SideLength *
               Math.Sin(60 * Math.PI / 180);
    }

    public override double GetPerimeter()
    {
        return SideLength * 4;
    }
}

class Rectangle : Shape
{
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }

    public Rectangle() : this(0, 0)
    {
    }

    public override double GetArea()
    {
        return Length * Width;
    }

    public override double GetPerimeter()
    {
        return 2 * (Length + Width);
    }
}

class Parallelogram : Shape
{
    public int BaseLength { get; set; }
    public int SideLength { get; set; }
    public double AngleDegrees { get; set; }

    public Parallelogram(int baseLength, int sideLength, double angleDegrees)
    {
        BaseLength = baseLength;
        SideLength = sideLength;
        AngleDegrees = angleDegrees;
    }

    public override double GetArea()
    {
        return BaseLength *
               SideLength *
               Math.Sin(AngleDegrees * Math.PI / 180);
    }

    public override double GetPerimeter()
    {
        return 2 * (BaseLength + SideLength);
    }
}

class Trapezoid : Shape
{
    public int Base1 { get; set; }
    public int Base2 { get; set; }
    public int Height { get; set; }
    public int Side1 { get; set; }
    public int Side2 { get; set; }

    public Trapezoid(
        int base1,
        int base2,
        int height,
        int side1,
        int side2)
    {
        Base1 = base1;
        Base2 = base2;
        Height = height;
        Side1 = side1;
        Side2 = side2;
    }

    public override double GetArea()
    {
        return ((Base1 + Base2) / 2.0) * Height;
    }

    public override double GetPerimeter()
    {
        return Base1 + Base2 + Side1 + Side2;
    }
}

class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public Circle() : this(0)
    {
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Ellipse : Shape
{
    public int RadiusA { get; set; }
    public int RadiusB { get; set; }

    public Ellipse(int radiusA, int radiusB)
    {
        RadiusA = radiusA;
        RadiusB = radiusB;
    }

    public Ellipse() : this(0, 0)
    {
    }

    public override double GetArea()
    {
        return Math.PI * RadiusA * RadiusB;
    }

    public override double GetPerimeter()
    {
        // Ramanujan approximation
        return Math.PI *
               (3 * (RadiusA + RadiusB) - Math.Sqrt((3 * RadiusA + RadiusB) * (RadiusA + 3 * RadiusB)));
    }
}

class ComplexShape : Shape
{
    private List<Shape> shapes = new List<Shape>();

    public void AddShape(Shape shape)
    {
        shapes.Add(shape);
    }

    public override double GetArea()
    {
        double total = 0;

        foreach (Shape shape in shapes)
        {
            total += shape.GetArea();
        }

        return total;
    }

    public override double GetPerimeter()
    {
        double total = 0;

        foreach (Shape shape in shapes)
        {
            total += shape.GetPerimeter();
        }

        return total;
    }
}

class Program
{
    static void Main()
    {
        ComplexShape complex = new ComplexShape();

        complex.AddShape(new Triangle(5));
        complex.AddShape(new Square(4));
        complex.AddShape(new Circle(3));

        Console.WriteLine($"Total Area: {complex.GetArea():F2}");

        Console.WriteLine($"Total Perimeter: {complex.GetPerimeter():F2}");
    }
}

// I hope both sides of your pillow are warm af tonight.
