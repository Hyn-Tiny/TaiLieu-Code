using System;

namespace StateFattern
{
    public class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.");
            this.context.Trasition(new ConcreteStateB());
        }

        public override void Handle2()
        {
            this.context.Trasition(new ConcreteStateB());
            Console.WriteLine("ConcreteStateA handles request2.");
        }
    }
}