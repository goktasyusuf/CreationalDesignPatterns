using FactoryMethodExample.Abstract;
using FactoryMethodExample.Concrete.BankFactories.GarantiBankFactory;
using FactoryMethodExample.Concrete.BankFactories.HalkbankFactory;
using FactoryMethodExample.Concrete.BankFactories.VakıfbankFactory;
using FactoryMethodExample.Enum;

namespace FactoryMethodExample.Concrete.BankFactory
{
    public static class BankFactory
    {
        public static IBank CreateInstance(BankType bankType)
        {
            IBankFactory _bankFactory = null;

            switch (bankType)
            {
                case BankType.Garanti:
                    _bankFactory = new GarantiBankFactory();
                    break;
                case BankType.Vakıfbank:
                    _bankFactory = new VakıfbankFactory();
                    break;
                case BankType.Halkbank:
                    _bankFactory = new HalkbankFactory();
                    break;
            }

            return _bankFactory.CreateInstance();
        }
    }
}
