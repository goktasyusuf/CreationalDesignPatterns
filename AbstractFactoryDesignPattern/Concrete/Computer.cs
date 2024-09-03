using AbstractFactoryDesignPattern.Abstract;

namespace AbstractFactoryDesignPattern.Concrete
{
    public class Computer
    {
        public ICpu Cpu { get; set; }
        public IRam Ram { get; set; }
        public IGraphicCard GraphicCard { get; set; }
    }
}
