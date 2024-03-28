using System;

namespace AnimalSounds
{
    // Abstract class representing an animal
    abstract class Animal : ISound
    {
        public string Type { get; }
        public string Sound { get; }

        protected Animal(string type, string sound)
        {
            Type = type;
            Sound = sound;
        }

        public abstract void MakeSound();
    }
}
