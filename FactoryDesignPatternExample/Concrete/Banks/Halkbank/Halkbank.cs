using FactoryMethodExample.Abstract;

namespace FactoryMethodExample.Concrete.Banks.Halkbank
{
    public class Halkbank : IBank
    {

        private string _password;
        public Halkbank()
        {
            Console.WriteLine($"{typeof(Halkbank)} istance created.");
            CreateConnection();
        }

        public string Password { set => _password = value; }

        public void CreateConnection()
        {
            Console.WriteLine("Halkbank - connected");
        }
    }
}
