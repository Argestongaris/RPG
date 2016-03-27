using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ExternalClasses
{
    class Monster:Creature
    {
        protected int GiveExp;
        protected int GiveGold;

        public Monster(int id, string name, int atakm, int defm, int dex, int agil, int will, int str, int speed, int endur,
                        int intel, int know, int giveExp, int giveGold) 
                        :base( id, name,  atakm,  defm,  dex,  agil,  will,  str,  speed,  endur, intel, know)
        {
            this.GiveExp = giveExp;
            this.GiveGold = giveGold;
        }

        public int GetGivenExp()
        {
            int num = this.GiveExp;
            return num;
        }
        public int GetGivenGold()
        {
            int num = this.GiveGold;
            return num;
        }
    }
}
