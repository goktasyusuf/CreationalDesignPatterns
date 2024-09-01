using FactoryMethodExample.Abstract;
using FactoryMethodExample.Concrete.Banks.Vakıfbank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample.Concrete.BankFactories.VakıfbankFactory
{
    public class VakıfbankFactory : IBankFactory
    {
        public IBank CreateInstance()
        {
            Vakıfbank vakıfBank = new(new VakıfbankCredentials { Password = "password" ,Email = "email",UserCode = "999"});
            vakıfBank.ValidationControl();
            return vakıfBank;
        }
    }
}
