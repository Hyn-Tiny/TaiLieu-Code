using System;

namespace FactoryMethod
{
    public class Dog : IAnimal
    {
        public void getName()
        {
            Console.WriteLine("go go");
        }
    }
}