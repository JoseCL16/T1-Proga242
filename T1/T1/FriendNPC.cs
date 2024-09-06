using System;

namespace T1
{
    public class FriendNPC : Trainer
    {
        public FriendNPC(string name) : base(name)
        {
        }

        public override void Greet()
        {
            Console.WriteLine($"Hi {Name}, have a potion");
        }
    }
}
