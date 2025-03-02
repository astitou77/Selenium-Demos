// See https://aka.ms/new-console-template for more information
// stuff
public class HelloJSP_World {

    public HelloJSP_World()
    {
        // Container
    }

    public void Adnane(int i)
    {
        Console.WriteLine("The number you input is: " + i);
    }

    public static void Main(String[] args)
    {
        // run stuff here

        Console.WriteLine("Hello, World!");
        var text = Console.ReadLine();

        Console.WriteLine("yo name is: " + text);
        var text2 = Console.ReadLine();

        HelloJSP_World a = new HelloJSP_World();
        a.Adnane(10);
    }

}

