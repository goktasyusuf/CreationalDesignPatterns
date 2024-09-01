using FactoryMethodExample.Abstract;
using FactoryMethodExample.Concrete.Banks.Garanti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample.Concrete.BankFactories.GarantiBankFactory
{
    public class GarantiBankFactory : IBankFactory
    {
        public IBank CreateInstance()
        {
            Garanti garanti = new("username", "password");
            garanti.CreateConnection();
            return garanti;
        }
    }
}
