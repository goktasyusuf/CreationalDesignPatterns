using AbstractFactoryDesignPattern.Concrete;

namespace AbstractFactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ComputerFactory.CreateComputer(new AsusComputerFactory());
             ComputerFactory.CreateComputer(new LenovoComputerFactory());
        }
    }
}
