using System;

namespace T1
{
    public class BadNPC : Trainer
    {
        public BadNPC(string name) : base(name)
        {
        }

        public override void Greet()
        {
            Console.WriteLine($"Let's battle {Name}");
        }
    }
}
