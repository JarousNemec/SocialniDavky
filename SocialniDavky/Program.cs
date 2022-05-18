using System;
using System.Collections.Generic;

namespace SocialniDavky
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new RationManager();
            var generator = new RandomNameGenerator();
            for (int i = 0; i < 15; i++)
            {
                manager.Add(generator.GenerateHuman());
            }
            manager.Proccess();
            Console.ReadKey();
        }
    }
}