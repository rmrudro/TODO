// See https://aka.ms/new-console-template for more information
Rectangle rec = new Rectangle(5, 8);

Console.WriteLine($"The Circumference of the rectangle is : {rec.CalculateCircumference()}");
Console.WriteLine($"The Area of the rectangle is {rec.CalculateArea()} ");
class Rectangle
{
    public readonly int Width;
    public readonly int Height;
    public Rectangle(int width, int height)
    {

        this.Width = GetLengthOrDefault(width, nameof(Width));
        this.Height = GetLengthOrDefault(height, nameof(Height));
        
    }

    private int GetLengthOrDefault(int length,string name)
    {
        const int DefaultvalueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} Must Be a Positive Number.");
            return DefaultvalueIfNonPositive;
            
        }
        return length;
    }

    public int CalculateCircumference() => 2 * Width + 2 * Height;

    public int CalculateArea() => Width * Height;

}
