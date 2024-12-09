namespace FactoryPattern;

public class ApplePhone : iMobilePhone
{
    public void Call()
    {
        Console.WriteLine("Calling using Apple Phone....");
    }

    public void Text()
    {
        Console.WriteLine("Texting using Apple Phone....");
    }
}