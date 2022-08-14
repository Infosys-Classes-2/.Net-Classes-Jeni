
namespace Members;
public class Person
{
    public double age;  //instance member
    public string name {get; set;}
    public static int noOfEyes = 2; //static member
}

public class Test  //shows erro while not usin name space... as without defining namespace it assumes it as global namespace so use namespace
{
    public void Do()
    {
        Person p1 = new();
        p1.age =45;  
        Person.noOfEyes =2;
        
    }
}