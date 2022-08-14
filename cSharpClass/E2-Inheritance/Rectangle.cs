public class Rectangle: IShape
{
    public Rectangle(double l,double b)
    {
        length = l;
        breath =b;
    }
    private double length;
    private double breath;

    public double GetArea() => length * breath;  //it's method defining style for one line methods called arrow method

    public double GetPerimeter() => 2*(length+breath);
    
}