using System;
namespace FactoryMethod
{
  public class Cat : IAnimal
  {
    public void getName()
    {
      Console.WriteLine("mew mew");
    }
  }
}