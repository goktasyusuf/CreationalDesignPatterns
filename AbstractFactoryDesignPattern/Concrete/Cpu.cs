using AbstractFactoryDesignPattern.Abstract;

namespace AbstractFactoryDesignPattern.Concrete
{
    public class Cpu : ICpu
    {
        public Cpu(string text)
        {
            Console.WriteLine($"{text} Cpu created.");
        }
    }
}
