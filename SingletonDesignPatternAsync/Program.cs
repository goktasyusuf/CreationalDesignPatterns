namespace SingletonDesignPatternAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var a = Task.Run(() =>
            {
                Singleton.GetInstance();
            });

            var b = Task.Run(() =>
            {
                Singleton.GetInstance();
            });

            var c = Task.Run(() =>
            {
                Singleton.GetInstance();
            });

            await Task.WhenAll(a, b, c);
        }
    }

    #region First Method
    class Singleton
    {
        private static Singleton _Instance;

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
            return _Instance;
        }

    }
    #endregion


    #region Second Method

    //class Singleton
    //{
    //    private static Singleton _Instance;
    //    private static object _InstanceLock = new object();

    //    private Singleton()
    //    {
    //        Console.WriteLine($"{typeof(Singleton)} instance generated.");
    //    }

    //    public static Singleton GetInstance()
    //    {
    //        lock (_InstanceLock)
    //        {
    //            if (_Instance == null) _Instance = new Singleton();
    //            return _Instance;
    //        }

    //    }
    //}
    #endregion
}