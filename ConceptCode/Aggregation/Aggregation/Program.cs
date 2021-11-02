using System;

namespace Aggregation
{
    public class Address
    {
        public string addressLine, city, state;
        public Address(string a, string c, string s)
        {
            addressLine = a;
            city = c;
            state = s;
        }
    }
    public class Employee
    {
        public int id;
        public string name;
        public Address address;
        public Employee(int id, string name,Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name + " " +
              address.addressLine + " " + address.city + " " + address.state);
        }
    }
    class TestAggregation
    {
        static void Main(string[] args)
        {
            Address address = new Address("G-13, Sec-3", "Noida", "UP");
            Employee e1 = new Employee(1, "Sonoo", address);
            e1.display();
        }
    }
}
