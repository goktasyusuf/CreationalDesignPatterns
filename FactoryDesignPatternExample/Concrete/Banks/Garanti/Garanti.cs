using FactoryMethodExample.Abstract;

namespace FactoryMethodExample.Concrete.Banks.Garanti
{
    public class Garanti : IBank
    {
        private string _userName;
        private string _password;
        public Garanti(string userName, string password)
        {
            Console.WriteLine($"{typeof(Garanti)} instance created.");
            _userName = userName;
            _password = password;
        }

        public void CreateConnection()
        {
            Console.WriteLine("Garanti - connected");
        }
    }
}
