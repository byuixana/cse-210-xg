public class Rectangle : Shape{
     private double _width;
     private double _heighth;
    public Rectangle(string color, double width, double heighth) : base(color)
    {
        _color = color;
        _width = width;
        _heighth = heighth;
    }

    public override double GetArea()
    {
        double area = _width * _heighth;
        return area;
    }


}