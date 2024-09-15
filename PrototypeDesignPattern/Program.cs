namespace PrototypeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Yusuf", "Göktaş", City.Istanbul, Departmant.A, 24, new Address { Country = "Türkiye", No = "24", StreetName = "Güzel" });
            //var person2 = new Person("Kerem","Göktaş",City.İzmir,Departmant.B,24,new Address { Country = "Türkiye",No = "24",StreetName ="Güzel"});

            var person2 = person1.Clone();
            person2.City = City.Ankara;
        }
    }



    public interface ICloneablePerson
    {
        Person Clone();
    }

    public class Person : ICloneablePerson
    {
        public Person(string name, string lastName, City city, Departmant departmant, int age, Address address)
        {
            Name = name;
            LastName = lastName;
            City = city;
            Departmant = departmant;
            Age = age;
            Address = address;

            Console.WriteLine("Instance Created...");
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public City City { get; set; }
        public Departmant Departmant { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public Person Clone()
        {
            return (Person)base.MemberwiseClone();
        }
    }

    public enum Departmant
    {
        A, B, C
    }

    public enum City
    {
        Istanbul, Ankara, İzmir
    }

    public class Address
    {
        public string StreetName { get; set; }
        public string Country { get; set; }
        public string No { get; set; }
    }
}
