using System;

namespace FightArena
{
    class Program
    {
        static void Main(string[] args)
        {
            ArenaController arenaController = new ArenaController();
            Console.WriteLine("WELCOME TO THE FIGHT ARENA!");

            arenaController.HeroCreater();

            foreach (Hero hero in arenaController.heroes)
            {
                Console.WriteLine(hero.Name);
            }


            Console.WriteLine("Quater Final Groups:");
            foreach (Hero fighter in arenaController.currentFight)
            {
                string heroesInFight = fighter;
                Console.WriteLine(fighter.Name);
            }

            bool fightersChosen = true;
            while (fightersChosen)
            {
                Console.WriteLine("Attacker attacks:");
                bool fighterOnesTurn = true;
                if (fighterOnesTurn == true)
                {
                    arenaController.HeroAttack(attackerAttackRange, defendersHitPoints, defendersDefence);
                }

                Console.WriteLine("Defender Health:");
            }

            Console.ReadKey();
        }
    }
}
