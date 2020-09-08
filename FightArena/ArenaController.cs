using System;
using System.Collections.Generic;
using System.Text;

namespace FightArena
{
    class ArenaController
    {
        public List<Hero> heroes = new List<Hero>();
        public List<Hero> currentFight = new List<Hero>();
        //public List<Hero> fightTwo = new List<Hero>();
        //public List<Hero> fightThree = new List<Hero>();
        //public List<Hero> fightFour = new List<Hero>();

        #region Create hero
        public KongFuHarry CreateHarry()
        {
            KongFuHarry harry = new KongFuHarry();
            return harry;
        }
        public SuperDogDino CreateDino()
        {
            SuperDogDino dino = new SuperDogDino();
            return dino;
        }
        public SpeedyKarl CreateKarl()
        {
            SpeedyKarl karl = new SpeedyKarl();
            return karl;
        }
        public PoisonGunner CreateGunner()
        {
            PoisonGunner gunner = new PoisonGunner();
            return gunner;
        }
        public MiniMouseMikkel CreateMikkel()
        {
            MiniMouseMikkel mikkel = new MiniMouseMikkel();
            return mikkel;
        }
        public TheCatTiger CreateTiger()
        {
            TheCatTiger tiger = new TheCatTiger();
            return tiger;
        }
        public RubberGoatIvan CreateIvan()
        {
            RubberGoatIvan ivan = new RubberGoatIvan();
            return ivan;
        }
        public MooseEgon CreateEgon()
        {
            MooseEgon egon = new MooseEgon();
            return egon;
        }
        public void HeroCreater()
        {
            heroes.Add(CreateHarry());
            heroes.Add(CreateDino());
            heroes.Add(CreateKarl());
            heroes.Add(CreateGunner());
            heroes.Add(CreateMikkel());
            heroes.Add(CreateTiger());
            heroes.Add(CreateIvan());
            heroes.Add(CreateEgon());
        }
        #endregion


        #region Quarter final
        public void QuarterFinal()
        {
            Random random = new Random();

            int randomFighterNumber = 1;

            foreach (Hero hero in heroes)
            {
                randomFighterNumber = random.Next(heroes.Count);
            }

            for (int i = 0; i <= 2; i++)
            {
                currentFight.Add(heroes[randomFighterNumber]);
                currentFight.Add(heroes[randomFighterNumber]);
                heroes.Remove(heroes[randomFighterNumber]);
                heroes.Remove(heroes[randomFighterNumber]);
            }

            //for (int i = 0; i <= 2; i++)
            //{
            //    fightTwo.Add(heroes[randomFighterNumber]);
            //    fightTwo.Add(heroes[randomFighterNumber]);
            //    heroes.Remove(heroes[randomFighterNumber]);
            //    heroes.Remove(heroes[randomFighterNumber]);
            //}

            //for (int i = 0; i <= 2; i++)
            //{
            //    fightThree.Add(heroes[randomFighterNumber]);
            //    fightThree.Add(heroes[randomFighterNumber]);
            //    heroes.Remove(heroes[randomFighterNumber]);
            //    heroes.Remove(heroes[randomFighterNumber]);
            //}
            //for (int i = 0; i <= 2; i++)
            //{
            //    fightFour.Add(heroes[randomFighterNumber]);
            //    fightFour.Add(heroes[randomFighterNumber]);
            //    heroes.Remove(heroes[randomFighterNumber]);
            //    heroes.Remove(heroes[randomFighterNumber]);
            //}

        }
        #endregion

        public void HeroAttack(attackerAttackRange, defenderHitPoints, defenderDefence)
        {
            int attackerDamage = attackerAttackRange;
            int defenderHitPoints = defenderHitPoints;
            int defenderDefence = defenderDefence;
            int damageGiven = 0;

            attackerDamage - defenderDefence = damageGiven; //Takes the attackers damage, minuesses it wth defender defence stats.

            damageGiven - defenderHitPoints; //Takes attackers total damage given and minuesses with the defender hitpoints.
        }

        #region Determine winner

        #endregion

    }
}
