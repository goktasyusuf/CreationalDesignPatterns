using AbstractFactoryDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Concrete
{
    public class GraphicCard : IGraphicCard
    {
        public GraphicCard(string text)
        {
            Console.WriteLine($"{text} Ram created.");
        }
    }
}
