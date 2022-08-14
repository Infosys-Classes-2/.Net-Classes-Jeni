public class Square: Rectangle //square gets interface through rectangle

{   
    public Square(double s): base (s,s)   
    // to call parent class property , methods we use base 
    {
        // Square.length =s;
        // Square.breath=s;
    }

}