using AbstractFactoryDesignPattern.Abstract;

namespace AbstractFactoryDesignPattern.Concrete
{
    public class LenovoComputerFactory : IComputerFactory
    {
        public ICpu CreateCpu()
        {
            return new Cpu("Lenovo");
        }

        public IGraphicCard CreateGraphicCard()
        {
            return new GraphicCard("Lenovo");
        }

        public IRam CreateRam()
        {
            return new Ram("Lenovo");
        }
    }
}
