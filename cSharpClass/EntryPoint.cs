class TestClasses
{
    public static void Main()
    {
        Animal cow = new Animal();// old version
        Animal goat = new ();  //new version
        var buffalo = new Animal(); // if declared as var
        Animal deer = new Animal();
        Animal fish = new Animal();
        Animal bear = new Animal();

        cow.weight =325.4f;
        cow.type = "Herbivorous animal cow";
        cow.PrintDetails();
    }
}