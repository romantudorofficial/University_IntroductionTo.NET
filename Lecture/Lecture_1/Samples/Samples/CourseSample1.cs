using System.Text;

namespace Samples
{
    public class CourseSample1
    {
        public static void Main()
        {
            // Create an object
            MyClass myObject = new MyClass();

            // Use the object
            myObject.DoSomething();

            // Set the object to null
            myObject = null;

            // Trigger garbage collection
            GC.Collect();

            // Wait for the garbage collector to finish
            GC.WaitForPendingFinalizers();

            // Check if the object has been garbage collected
            if (myObject == null)
            {
                Console.WriteLine("The object has been garbage collected.");
            }
            else
            {
                Console.WriteLine("The object has not been garbage collected.");
            }
        }
    }

    public class MyClass
    {
        ~MyClass()
        {
            Console.WriteLine("MyClass object is being finalized.");
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }
    }
    public class StringConcatenator
    {
        public string ConcatenateStrings(params string[] strings)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string str in strings)
            {
                sb.Append(str);
            }

            return sb.ToString();
        }
    }
}