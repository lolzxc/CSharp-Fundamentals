namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            UseGenericList();
        }
        
        static void UseGenericList()
        {
            Console.WriteLine("Generics");

            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Jim", "Garrido", 23));
            Console.WriteLine(morePeople[0]);

        }
    }
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {

        }
        public Person (string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}