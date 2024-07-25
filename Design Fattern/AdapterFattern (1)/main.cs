using System;
namespace AdapterPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Adaptee adaptee = new Adaptee();

            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Client: I can work just fine with the Target objects:" + target.GetRequest());

        }


    }

}