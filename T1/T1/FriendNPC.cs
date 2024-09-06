using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
