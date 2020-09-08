using System;
using System.Collections.Generic;
using System.Text;

namespace FightArena
{
    class SpeedyKarl:Hero
    {
        private bool rightUppercut;

        public bool RightUppercut
        {
            get { return rightUppercut; }
            set { rightUppercut = value; }
        }

        public SpeedyKarl()
        {
            Name = "Hurtig Karl";
            HitPoints = 90;
            AttackRange = 5;
            DefencePoints = 3;
        }
    }
}
