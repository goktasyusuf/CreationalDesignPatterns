using FactoryMethodExample.Abstract;
using FactoryMethodExample.Concrete.Banks.Halkbank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample.Concrete.BankFactories.HalkbankFactory
{
    public class HalkbankFactory : IBankFactory
    {
        public IBank CreateInstance()
        {
            Halkbank halkbank = new();
            halkbank.Password = "123";
            return halkbank;
        }
    }
}
