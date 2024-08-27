
namespace MultitonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiton.CrateInstance("value1");

            Multiton.CrateInstance("value2");

            Multiton.CrateInstance("value1");

            Multiton.CrateInstance("value2");
        }
    }

    class Multiton
    {
        private Multiton()
        {
            Console.WriteLine($"{typeof(Multiton)} instance generated");
        }

        public static Dictionary<string,Multiton> _instances = new Dictionary<string,Multiton>();

        public static Multiton CrateInstance(string key)
        {
            if(!_instances.ContainsKey(key)) _instances[key] = new Multiton();
            return _instances[key];
        }
    }
}
