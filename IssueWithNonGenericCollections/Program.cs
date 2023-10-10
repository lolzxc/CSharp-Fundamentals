using System.Collections;
namespace IssueWithNonGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WorkingWithArrayList(); 
        }
        
        static void WorkingWithArrayList()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(1);
            myInts.Add(2);
            myInts.Add(3);

            int i = (int)myInts[0];

            Console.WriteLine("Value of your int: {0}", i);
        }
    }
}