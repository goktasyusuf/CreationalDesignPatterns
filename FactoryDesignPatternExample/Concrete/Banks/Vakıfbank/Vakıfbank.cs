using FactoryMethodExample.Abstract;

namespace FactoryMethodExample.Concrete.Banks.Vakıfbank
{
    public class Vakıfbank : IBank
    {
        private string _userCode;
        private string _email;
        private string _password;

        public Vakıfbank(VakıfbankCredentials credantials)
        {
            _userCode = credantials.UserCode;
            _email = credantials.Email;
            _password = credantials.Password;
            Console.WriteLine($"{typeof(Vakıfbank)} istance created.");
        }

        public bool ValidationControl()
        {
            Console.WriteLine($"Vakıfbank - Connected after validate => {_email} + {_userCode} ");
            return true;
        }


    }


    public class VakıfbankCredentials
    {
        public string UserCode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
