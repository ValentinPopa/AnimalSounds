using System;
using System.Collections.Generic;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of animals
            List<Animal> animals = new List<Animal>
            {
                new Cat(),
                new Dog(),
                new Cow()
            };

            // Iterate through the list and make each animal sound
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
