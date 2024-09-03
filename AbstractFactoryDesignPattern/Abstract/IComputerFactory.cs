using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Abstract
{
    public interface IComputerFactory
    {
        ICpu CreateCpu();
        IRam CreateRam();
        IGraphicCard CreateGraphicCard();
    }
}
