using System;

namespace FactoryMethod
{
  public class CreateCat : AnimalFactory
  {
    public override IAnimal CreateAnimalFactory()
    {
      return new Cat();
    }
  }
}