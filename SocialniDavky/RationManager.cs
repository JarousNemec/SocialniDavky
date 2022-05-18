using System;
using System.Collections.Generic;

namespace SocialniDavky
{
    public class RationManager
    {
        private Queue<Human> _humans;
        private int tolalRation;
        private Random r;

        public RationManager()
        {
            _humans = new Queue<Human>();
            r = new Random();
        }

        public void Add(Human human)
        {
            _humans.Enqueue(human);
        }

        public void Proccess()
        {
            GenerateTotalRation();
            if (_humans.Count > 0)
            {
                DivideRations();
            }
        }

        private const int AVG_RATION = 20000;

        private void GenerateTotalRation()
        {
            tolalRation = r.Next(AVG_RATION, (AVG_RATION * _humans.Count));
        }

        private void DivideRations()
        {
            int ration = 0;
            for (int i = 0; i < _humans.Count; i++)
            {
                ration = r.Next(AVG_RATION - 10000, (AVG_RATION + 20000));
                if (i == _humans.Count - 1)
                {
                    var human = _humans.Dequeue();
                    human.Ration = tolalRation;
                    PrintAction(human, $" {(human.Gender > 50 ? "dostal" : "dostala")} zbylou castku ", ration);
                    break;
                }

                if (ration < tolalRation)
                {
                    var human = _humans.Dequeue();
                    human.Ration = ration;

                    PrintAction(human, $" {(human.Gender > 50 ? "dostal" : "dostala")} castku ", ration);
                    tolalRation -= ration;
                    ration = 0;
                }
                else
                {
                    var human = _humans.Dequeue();
                    human.Ration = ration;
                    PrintAction(human, $" {(human.Gender > 50 ? "dostal" : "dostala")} zbylou castku ", ration);
                    break;
                }
            }

            if (_humans.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nedostalo se na:");
                foreach (var human in _humans)
                {
                    Console.WriteLine(human);
                }

                Console.ResetColor();
            }
        }

        private void PrintAction(Human h, string msg, int ration)
        {
            Console.WriteLine(h + msg + ration + " Kč");
        }
    }
}