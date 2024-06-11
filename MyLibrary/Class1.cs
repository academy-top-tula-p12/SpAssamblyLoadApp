namespace MyLibrary
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee() 
        {
            Name = "Anonim";
            Age = 0;
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
