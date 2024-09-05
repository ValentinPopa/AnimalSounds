using System;

namespace AnimalSounds
{
    // Class representing a cat
    class Cat : Animal
    {
        public Cat() : base("Cat", "Meow") { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Type} makes sound: {Sound}");
        }
    }
}
