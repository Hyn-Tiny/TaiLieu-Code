namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        private Adaptee adaptee;

        public Adapter(Adaptee adptee)
        {
            this.adaptee = adptee;
        }
        public string GetRequest()
        {
            return $"Request:{this.adaptee.GetSpecificRequest()}.";
        }
    }
}