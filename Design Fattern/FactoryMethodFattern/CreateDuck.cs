using System;

namespace FactoryMethod
{
  public class CreateDuck : AnimalFactory
  {
    public override IAnimal CreateAnimalFactory()
    {
      return new Duck();
    }
  }
}