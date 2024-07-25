using System;

namespace StateFattern
{
    public class Context
    {
        private State state;

        public Context(State state)
        {
            this.Trasition(state);
        }

        public void Trasition(State state)
        {
            Console.WriteLine($"trang thai cua ban la: {state.GetType().Name}");
            this.state = state;
            this.state.SetContext(this);
        }
        public void Request1()
        {
            this.state.Handle1();
        }
        public void Request2()
        {
            this.state.Handle2();
        }
    }
}