using System;

namespace T1
{
    public class Trainer
    {
        public string Name { get; set; }

        public Trainer(string name)
        {
            Name = name;
        }

        public virtual void Greet()
        {
            Console.WriteLine($"Hi {Name}");
        }
    }
}
