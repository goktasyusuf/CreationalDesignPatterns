using AbstractFactoryDesignPattern.Abstract;

namespace AbstractFactoryDesignPattern.Concrete
{
    public class AsusComputerFactory : IComputerFactory
    {
        public ICpu CreateCpu()
        {
            return new Cpu("Asus");
        }

        public IGraphicCard CreateGraphicCard()
        {
            return new GraphicCard("Asus");
        }

        public IRam CreateRam()
        {
            return new Ram("Asus");
        }
    }
}
