using System.Collections.Concurrent;

namespace ObjectPoolDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectPool<X> pool = new();
            pool.AcquireObject(() => new X());
            Console.WriteLine($"Counter => {pool.GetCounter} ");

            pool.AcquireObject(() => new X());
            Console.WriteLine($"Counter => {pool.GetCounter} ");

            pool.AcquireObject(() => new X());
            Console.WriteLine($"Counter => {pool.GetCounter} ");


            pool.AcquireObject(() => new X());
            Console.WriteLine($"Counter => {pool.GetCounter} ");

            var y = pool.AcquireObject(() => new X());
            Console.WriteLine($"Counter => {pool.GetCounter} ");

            pool.ReleaseObject(y);

            pool.AcquireObject(() => new X());
            Console.WriteLine($"Counter => {pool.GetCounter} ");


            pool.ReleaseObject(y);

            pool.AcquireObject(() => new X());
            Console.WriteLine($"Counter => {pool.GetCounter} ");




            //If we want to request a new object without calling the ReleaseObject method, it will give an error.
            //pool.ReleaseObject(y);
            pool.AcquireObject(() => new X());
            Console.WriteLine($"Counter => {pool.GetCounter} ");


        }
    }

    public class X
    {
        public X()
        {
            Console.WriteLine("Costly instance created");
        }

        ~X()
        {
            Console.WriteLine("Costly instance destroyed");
        }
    }

    public class ObjectPool<T> where T : class, new()
    {
        private int _poolSize = 5;
        private int _counter = 1;
        private readonly ConcurrentBag<T> _instances = new ConcurrentBag<T>();

        public int GetPoolSize { get => _poolSize; }
        public int GetCounter { get => _counter; }


        public T AcquireObject(Func<T>? objectGenerator = null)
        {
            if (!_instances.TryTake(out T? instance))
            {
                if (_counter > _poolSize) throw new Exception("The maximum object capacity of the pool has been reached!");
                instance = objectGenerator != null ? objectGenerator() : new T();
                Interlocked.Increment(ref _counter);
            }
            return instance;

        }

        public void ReleaseObject(T instance)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            _instances.Add(instance);
        }
    }
}
