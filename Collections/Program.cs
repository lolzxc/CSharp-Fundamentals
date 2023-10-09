using System.Collections;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayListExample arrayListExample = new ArrayListExample();
        }
    }

    public class ArrayListExample
    {
        public ArrayListExample()
        {
            ArrayList strArray = new ArrayList();
            strArray.AddRange(new String[] { "First", "Second", "Third " });

            Console.WriteLine("This collection has {0} items.", strArray.Count);
            Console.WriteLine();

            strArray.Add("Fourth");
            Console.WriteLine("This collection has {0} items.", strArray.Count);

            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }
    }
}