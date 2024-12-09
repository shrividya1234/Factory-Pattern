using System.Linq.Expressions;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of phone do you have..( iPhone/Apple , Android, Google) ???");
            var phonetype = Console.ReadLine();
            var phone = PhoneFactory.BuildiPhone(phonetype);
            phone.Call();
            phone.Text();
        }
    }
}
