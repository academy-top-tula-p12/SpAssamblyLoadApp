using SpAssamblyLoadApp;

namespace MyLibrary
{
    //public class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person()
    //    {
    //        Name = "Anonim";
    //        Age = 0;
    //    }

    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public virtual void Info()
    //    {
    //        Console.WriteLine($"Name: {Name}, Age: {Age}");
    //    }
    //}
    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee() : base()
        {
            Salary = 0.0m;
        }

        public Employee(string name, int age) : this(name, age, 0.0m) {}

        public Employee(string name, int age, decimal salary) : base(name, age)
        { 
            Salary = salary; 
        }

        public override void Info()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
        }
    }

    public class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; protected set; }

        public Account()
        {
            Name = "Simple";
            Balance = 0m;
        }
    }

}
