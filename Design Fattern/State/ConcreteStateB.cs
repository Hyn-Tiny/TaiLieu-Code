using System;

namespace StateFattern
{
    public class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.Write("ConcreteStateB handles request1.");
            this.context.Trasition(new ConcreteStateA());
        }

        public override void Handle2()
        {
            this.context.Trasition(new ConcreteStateA());
            Console.WriteLine("ConcreteStateB handles request2.");
            Console.WriteLine("ConcreteStateB wants to change the state of the context.");
        }
    }
}