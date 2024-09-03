using AbstractFactoryDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Concrete
{
    public static class ComputerFactory
    {
        public static Computer CreateComputer(IComputerFactory factory) => new Computer { Cpu = factory.CreateCpu(),GraphicCard = factory.CreateGraphicCard(),Ram = factory.CreateRam() };
    }
}
