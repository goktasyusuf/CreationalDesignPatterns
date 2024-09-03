using AbstractFactoryDesignPattern.Abstract;

namespace AbstractFactoryDesignPattern.Concrete
{
    public class Ram : IRam
    {
        public Ram(string text)
        {
            Console.WriteLine($"{text} Ram created.");
        }
    }
}
