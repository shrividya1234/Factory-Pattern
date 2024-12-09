namespace FactoryPattern;

public class GooglePhone : iMobilePhone
{
    public void Call()
    {
        Console.WriteLine("Calling through Google Phone");
    }

    public void Text()
    {
        Console.WriteLine("Texting through Google Phone");
    }
}