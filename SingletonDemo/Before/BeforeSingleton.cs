namespace SingletonDemo.Before
{
    public class BeforeSingleton
    {
        private static int counter = 0;

        public BeforeSingleton()
        {
            counter++;
        }

        public void GetCounter()
        {
            Console.WriteLine(counter);
        }
    }
}
