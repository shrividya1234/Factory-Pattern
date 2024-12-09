namespace FactoryPattern;

public class AndroidPhone : iMobilePhone
{
    public void Call()
    {
        Console.WriteLine("calling through android phone....");
    }

    public void Text()
    {
        Console.WriteLine("Texting through android phone....");
    }
}