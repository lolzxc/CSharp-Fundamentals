namespace FunWithGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UseSortedSet();
        }

        static void UseGenericList()
        {
            List<Person> people = new List<Person>
            {
                new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 },
                new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 }
            };

            Console.WriteLine("Items in list: {0}", people.Count);

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n->Inserting new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list: {0}", people.Count);

            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine("First Names: {0}", p.FirstName);
            }
        }

        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new();
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person item is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());

            try
            {
                Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message);
            }
        }

        static void UseGenericQueue()
        {
            Queue<Person> peopleQueue = new();
            peopleQueue.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleQueue.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQueue.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9});

            Console.WriteLine("{0} is first in line!", peopleQueue.Peek().FirstName);

            GetCoffee(peopleQueue.Dequeue());
            GetCoffee(peopleQueue.Dequeue());
            GetCoffee(peopleQueue.Dequeue()); 

            try
            {
                GetCoffee(peopleQueue.Dequeue());
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Error! {0}", ex.Message);
            }

            static void GetCoffee(Person p)
            {
                Console.WriteLine("{0} got coffee!", p.FirstName);
            }
        }

        static void UsePriorityQueue()
        {
            Console.WriteLine("Fun with Generic Priority Queue");

            PriorityQueue<Person, int> peopleQueue = new();
            peopleQueue.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 }, 3);
            peopleQueue.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 }, 3);
            peopleQueue.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }, 1);
            peopleQueue.Enqueue(new Person { FirstName = "Bart", LastName = "Simpson", Age = 9 }, 2);

            while (peopleQueue.Count > 0)
            {
                Console.WriteLine(peopleQueue.Dequeue().FirstName);
                Console.WriteLine(peopleQueue.Dequeue().FirstName);
                Console.WriteLine(peopleQueue.Dequeue().FirstName);
                Console.WriteLine(peopleQueue.Dequeue().FirstName);
            }
        }

        static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 },
                new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 }
            };

            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });

            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int age)
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

    public class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person? firstPerson, Person? secondPerson)
        {
            if (firstPerson?.Age > secondPerson?.Age) { return 1; }
            if (firstPerson?.Age < secondPerson?.Age) { return -1; }
            return 0;
        }
    }
}