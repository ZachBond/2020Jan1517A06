using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InheritanceDemo.Animals;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoAnimals();
            //PlayMineWeeper();

            Console.ReadLine();
        }

        private static void DemoAnimals()
        {
            AnimalControlOfficer officer = new AnimalControlOfficer(20);
            officer.Patrol();
            officer.Report();
        }

        private static void PlayMineWeeper()
        {
            GameEngine game = new GameEngine(new GameUI.GameConsole());
            game.Play();
        }
    }
}
