var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;
    protected Shape()  // เปลี่ยนเป็น protected
    {
        System.Console.WriteLine("This is some shape with unknown side");
    }
    
    public Shape(int numOfSide)
    {
        System.Console.WriteLine($"This is some shape with {numOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base()  // ใช้ base() เรียก constructor ของ Shape
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4)  // ใช้ base(4) เพื่อบอกว่า Rectangle มี 4 ด้าน
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3)  // ใช้ base(3) เพื่อบอกว่า Triangle มี 3 ด้าน
    {
        System.Console.WriteLine("This is a triangle");
    }
}
