namespace SingletonDemo.After
{
    // The Singleton class is a design pattern that ensures that only one instance of a class is created and provides a global point of access to that instance.
    // The Singleton pattern is useful when you want to control access to a shared resource, such as a database connection or a configuration file, and ensure that only one instance of the class is created throughout the application.

    //Step 1: Make variable to hold the single instance of the class and make it private
    //Step 2: Make the constructor private to prevent instantiation from outside the class
    //Step 3: Provide a public static method that returns the single instance of the class, creating it if it doesn't already exist
    //Step 4: Make the class sealed to prevent inheritance and ensure that only one instance of the class can be created.
    // In a multithreaded environment, the singleton pattern can be implemented using a thread-safe approach to ensure that only one instance of the class is created, even when multiple threads are trying to access it simultaneously.

    public sealed class Singleton
    {
        // Counter variable to demonstrate that only one instance of the class is created
        private static int counter = 0;

        //STEP 1: Make variable to hold the single instance of the class and make it private
        //private static Singleton? instance = null;

        // Object used for locking to ensure thread safety in the double-checked locking implementation
        //private static readonly object instancelock = new object();

        // Thread-safe implementation of the singleton pattern using Lazy<T>
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());


        //STEP 2: Make the constructor private to prevent instantiation from outside the class
        private Singleton()
        {
            counter++;
        }

        //STEP 3: Provide a public static method that returns the single instance of the class, creating it if it doesn't already exist
        public static Singleton GetInstance()
        {
            return instance.Value;
        }

        //STEP 3: Alternative implementation of GetInstance method using double-checked locking
        /*
        public static Singleton GetInstance()
        {

            //STEP 3: Provide a public static method that returns the single instance of the class, creating it if it doesn't already exist
            if (instance == null)
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
        */

        // Method to demonstrate that only one instance of the class is created
        public void GetCounter()
        {
            Console.WriteLine(counter);
        }

        //STEP 4: Make the class sealed to prevent inheritance and ensure that only one instance of the class can be created.
        /*
        public class NestedInSingleton : Singleton
        {

        }
        */
    }

}
