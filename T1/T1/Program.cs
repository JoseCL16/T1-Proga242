using System;

namespace T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input trainer name: ");
            string trainerName = Console.ReadLine();

            Console.Write("¿Friendly trainer (yes/no): ");
            string isFriendly = Console.ReadLine().ToLower();

            Trainer trainer;

            if (isFriendly == "yes")
            {
                trainer = new FriendNPC(trainerName);
            }
            else
            {
                trainer = new BadNPC(trainerName);
            }

            trainer.Greet();
            Console.ReadLine();
        }
    }
}