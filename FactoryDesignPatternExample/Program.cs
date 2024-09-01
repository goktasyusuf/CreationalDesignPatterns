using FactoryMethodExample.Concrete.BankFactory;

namespace FactoryMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankFactory.CreateInstance(Enum.BankType.Garanti);
            BankFactory.CreateInstance(Enum.BankType.Halkbank);
            BankFactory.CreateInstance(Enum.BankType.Vakıfbank);
        }
    }
}
