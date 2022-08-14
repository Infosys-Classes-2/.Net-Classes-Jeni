public class Test
{
    void CalculateAreas()
    {
        // Rectangle rectangle1 = new();
        // rectangle1.legth = 3.2;
        // rectangle1.breath =2.4;
        // or 
        // Rectangle rectangle1 = new(34.2,22.4); //by defining a constructor in class rectangle

        // var area1= rectangle1.GetArea();
        // var param1= rectangle1.GetPerimeter();

        // Square square1 = new(33.2);
        // var area2=square1.GetArea();
        // var peri = square1.GetPerimeter();

        // Triangle t1 = new(23.4,44.4,333.2);
        // var area3 = t1.GetArea();
        // var per3 = t1.GetPerimeter();

        //or

        IShape rect1 = new Rectangle(22.3,44.2);
        var area1 = rect1.GetArea();
        var peri1 = rect1.GetPerimeter();

    }
}