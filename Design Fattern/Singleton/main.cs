using System;
namespace DesignFattern
{
    class Singleton
    {
        private int index;
        public Singleton(int index)
        {
            this.index = index;
        }
        private static Singleton instance;
        public static Singleton Instance()
        {
            if (instance == null)
            {

                Random random = new Random();
                instance = new Singleton(random.Next(1, 4));

            }
            return instance;
        }
        public void test()
        {
            Random random = new Random();
            Console.WriteLine("test{0}", random.Next(1, 4));
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // The client code.
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            s1.test();
            s2.test();
            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance." + s1 + " " + s2);
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}