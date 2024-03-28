using System;

namespace AnimalSounds
{
    // Class representing a dog
    class Dog : Animal
    {
        public Dog() : base("Dog", "Woof") { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Type} makes sound: {Sound}");
        }
    }
}
