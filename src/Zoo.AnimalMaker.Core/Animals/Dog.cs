﻿namespace Zoo.AnimalMaker.Core.Animals
{
    /// <summary>
    /// Class representing a Cat
    /// History:
    /// [2013-07-16 :Dinesh]: Refactored to be inheriting from the AbstractAnimal class that implments the IAnimal interface
    /// </summary>
    public class Dog : AbstractAnimal
    {
        public Dog(IAnimalRepository animalRepository): base(animalRepository)
        {
        }
    }
}
