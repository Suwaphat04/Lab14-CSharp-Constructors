var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;

    private Shape() // constructor เริ่มต้นแบบ private
    {
    }

    public Shape(int NumOfSide) : this() // constructor ที่รับพารามิเตอร์
    {
        this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base(0) // เรียกใช้ constructor ของ Shape พร้อมส่ง 0 เพื่อบ่งบอกว่าเป็นวงกลม
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4) // เรียกใช้ constructor ของ Shape พร้อมส่ง 4 เพื่อบ่งบอกว่าเป็นสี่เหลี่ยม
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3) // เรียกใช้ constructor ของ Shape พร้อมส่ง 3 เพื่อบ่งบอกว่าเป็นสามเหลี่ยม
    {
        System.Console.WriteLine("This is a triangle");
    }
}

