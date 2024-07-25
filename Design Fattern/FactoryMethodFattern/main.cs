using System;

namespace FactoryMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            IAnimal animal = new Dog();
            animal.getName();
            animal = new Cat();
            animal.getName();

//dung factory method
            AnimalFactory animalfacotry = new CreateDog();
            IAnimal animalFactory = animalfacotry.CreateAnimalFactory();
            animalFactory.getName();
        }
    }
}
