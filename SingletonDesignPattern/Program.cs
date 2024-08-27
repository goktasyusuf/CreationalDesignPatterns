namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton.GetInstance();
            Console.WriteLine(Singleton.Count);
            Singleton.GetInstance();
            Console.WriteLine(Singleton.Count);
            Singleton.GetInstance();
            Console.WriteLine(Singleton.Count);
        }
    }

    #region First Method
    class Singleton
    {
        private static Singleton _Instance;
        public static int Count;
        private Singleton()
        {
            Console.WriteLine($"{typeof(Singleton)} instance generated.");
        }
        static Singleton()
        {
            _Instance = new Singleton();
        }
        public static Singleton GetInstance()
        {
            Count++;
            return _Instance;
        }
    }

    #endregion


    #region Second Method

    //class Singleton
    //{
    //    private static Singleton _Instance;
    //    public static int Count;
    //    private Singleton()
    //    {
    //        Console.WriteLine($"{typeof(Singleton)} instance generated.");
    //    }

    //    public static Singleton GetInstance()
    //    {
    //        Count++;
    //        _Instance ??= new Singleton();
    //        return _Instance;
    //    }
    //}

    #endregion
}
