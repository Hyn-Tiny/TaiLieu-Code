using System;
namespace StateFattern
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            State state1 = new ConcreteStateA();
            State state2 = new ConcreteStateB();

            Context context = new Context(state1);
            Context context2 = new Context(state2);

            context.Request1();
            context.Request2();
        }

    }


}
