using System;
using System.Collections.Generic;
using System.Text;

namespace FightArena
{
    class Hero
    {
        #region Variables
        private string name;
        private int attackRange; //The hero attack range
        private int defencePoints; //The hero defence points
        private int hitPoints; //The hero hit points.
        #endregion

        #region get set
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }
        public int DefencePoints
        {
            get { return defencePoints; }
            set { defencePoints = value; }
        }
        public int HitPoints
        {
            get { return hitPoints; }
            set { hitPoints = value; }
        }
        #endregion

        public Hero ()
        {

        }
    }
}
