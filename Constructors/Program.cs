namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1, FirstName="Enes", LastName="Samancioglu", City="Izmir"};

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Erdem", "Samancioglu", "Izmir");

            Console.WriteLine(customer2.FirstName);

        }
    }
    class Customer
    {
        //Deafult Constructor
        public Customer()
        {
            
        }

        //Bir sinifi new ledigimizde calismasini istedigimiz kodlari constructor a koyariz.
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}