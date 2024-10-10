namespace BuilderDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = CarDirector.Build(new BMWBuilder());
            bmw.ToString();
            Car opel = CarDirector.Build(new OpelBuilder());
            opel.ToString();
            Car mercedes = CarDirector.Build(new MercedesBuilder());
            mercedes.ToString();
        }
    }

    //Product
    public class Car
    {
        public string KM { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            Console.WriteLine($"{this.Brand} - {this.Model} - {this.KM} km car created.");
            return base.ToString();
        }
    }


    public abstract class IAbstractBuilder
    {
        private Car Car { get; set; }
        public Car GetCar { get => Car; }

        protected IAbstractBuilder()
        {
            Car = new Car();
        }
        public abstract void SetBrand();
        public abstract void SetModel();
        public abstract void SetKM();

    }

  
    public class BMWBuilder : IAbstractBuilder
    {
        public override void SetBrand()
        {
            GetCar.Brand = "BMW";

        }

        public override void SetKM()
        {
            GetCar.KM = "10";
        }

        public override void SetModel()
        {
            GetCar.Model = "X5";
        }
    }

    public class OpelBuilder : IAbstractBuilder
    {
        public override void SetBrand()
        {
            GetCar.Brand = "Opel";
        }

        public override void SetKM()
        {
            GetCar.KM = "5000";
        }

        public override void SetModel()
        {
            GetCar.Model = "Astra";
        }
    }

    public class MercedesBuilder : IAbstractBuilder
    {
        public override void SetBrand()
        {
            GetCar.Brand = "Mercedes";
        }

        public override void SetKM()
        {
            GetCar.KM = "0";
        }

        public override void SetModel()
        {
            GetCar.Model = "C180";
        }
    }


  
    public static class CarDirector
    {
        public static Car Build(IAbstractBuilder builder)
        {
            builder.SetBrand();
            builder.SetModel();
            builder.SetKM();
            return builder.GetCar;
        }

    }
}
