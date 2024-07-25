using System;

namespace FactoryMethod
{
  public class CreateDog : AnimalFactory
  {
    public override IAnimal CreateAnimalFactory()
    {
      return new Dog();
    }
    
  }
}