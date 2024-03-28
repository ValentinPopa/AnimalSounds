using System;

namespace AnimalSounds
{
    // Class representing a cow
    class Cow : Animal
    {
        public Cow() : base("Cow", "Moo") { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Type} makes sound: {Sound}");
        }
    }
}
